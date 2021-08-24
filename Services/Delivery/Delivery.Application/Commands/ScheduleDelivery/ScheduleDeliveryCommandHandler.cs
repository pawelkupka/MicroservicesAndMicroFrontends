using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Delivery.Application.Commands.ScheduleDelivery
{
    using Domain.Model.Couriers;
    using Domain.Model.Deliveries;

    public class ScheduleDeliveryCommandHandler : IRequestHandler<ScheduleDeliveryCommand>
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly ICourierRepository _courierRepository;

        public ScheduleDeliveryCommandHandler(IDeliveryRepository deliveryRepository, ICourierRepository courierRepository)
        {
            _deliveryRepository = deliveryRepository;
            _courierRepository = courierRepository;
        }

        public async Task<Unit> Handle(ScheduleDeliveryCommand command, CancellationToken cancellationToken)
        {
            var availableCouriers = await _courierRepository.FindAllAvailableAsync();
            if (availableCouriers.Any())
            {
                var delivery = await _deliveryRepository.FindByOrderIdAsync(command.OrderId);
                var courier = availableCouriers.First();
                var pickupAddress = new ActionAddress(delivery.PickupAddress.Line1, delivery.PickupAddress.Line2, delivery.PickupAddress.City, delivery.PickupAddress.PostalCode);
                var deliveryAddress = new ActionAddress(delivery.DeliveryAddress.Line1, delivery.DeliveryAddress.Line2, delivery.DeliveryAddress.City, delivery.DeliveryAddress.PostalCode);
                courier.AddAction(Action.MakePickup(delivery.DeliveryId, pickupAddress, command.WhenReadyForPickup));
                courier.AddAction(Action.MakeDropoff(delivery.DeliveryId, deliveryAddress, command.WhenReadyForPickup.AddMinutes(30)));
                delivery.Schedule(courier.CourierId, command.WhenReadyForPickup);
                await _courierRepository.UpdateAsync(courier);
                await _deliveryRepository.UpdateAsync(delivery);
            }
            return Unit.Value;
        }
    }
}
