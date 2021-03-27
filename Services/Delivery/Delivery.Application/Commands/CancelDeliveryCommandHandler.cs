using System.Threading.Tasks;

namespace Delivery.Application.Commands
{
    using Common.Application.Commands;
    using Domain.Model;

    public class CancelDeliveryCommandHandler : ICommandHandler
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly ICourierRepository _courierRepository;

        public CancelDeliveryCommandHandler(IDeliveryRepository deliveryRepository, ICourierRepository courierRepository)
        {
            _deliveryRepository = deliveryRepository;
            _courierRepository = courierRepository;
        }

        public async Task HandleAsync(CancelDeliveryCommand command)
        {
            var delivery = await _deliveryRepository.FindByOrderIdAsync(command.OrderId);
            delivery.Cancel();
            await _deliveryRepository.UpdateAsync(delivery);
            if (delivery.CourierId.HasValue)
            {
                var courier = await _courierRepository.FindByIdAsync(delivery.CourierId.Value);
                courier.RemoveDelivery(delivery.DeliveryId);
                await _courierRepository.UpdateAsync(courier);
            }
        }
    }
}
