using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Application.Commands
{
    using Common.Application.Commands;
    using Domain.Model;

    public class ScheduleDeliveryCommandHandler : ICommandHandler
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly ICourierRepository _courierRepository;

        public ScheduleDeliveryCommandHandler(IDeliveryRepository deliveryRepository, ICourierRepository courierRepository)
        {
            _deliveryRepository = deliveryRepository;
            _courierRepository = courierRepository;
        }

        public async Task HandleAsync(ScheduleDeliveryCommand command)
        {
            var couriers = await _courierRepository.FindAllAvailableAsync();
            if (couriers.Any())
            {
                var delivery = await _deliveryRepository.FindByOrderIdAsync(command.OrderId);
                var courier = couriers.First();
                courier.AddAction(DeliveryAction.MakePickup(delivery.DeliveryId, delivery.PickupAddress, command.WhenReadyForPickup));
                courier.AddAction(DeliveryAction.MakeDropoff(delivery.DeliveryId, delivery.DeliveryAddress, command.WhenReadyForPickup.AddMinutes(30)));
                delivery.Schedule(courier.CourierId, command.WhenReadyForPickup);
                await _courierRepository.UpdateAsync(courier);
                await _deliveryRepository.UpdateAsync(delivery);
            }
        }
    }
}
