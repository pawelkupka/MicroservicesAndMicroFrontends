using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Delivery.Application.Commands.CancelDelivery
{
    using Domain.Model.Couriers;
    using Domain.Model.Deliveries;

    public class CancelDeliveryCommandHandler : IRequestHandler<CancelDeliveryCommand>
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly ICourierRepository _courierRepository;

        public CancelDeliveryCommandHandler(IDeliveryRepository deliveryRepository, ICourierRepository courierRepository)
        {
            _deliveryRepository = deliveryRepository;
            _courierRepository = courierRepository;
        }

        public async Task<Unit> Handle(CancelDeliveryCommand command, CancellationToken cancellationToken)
        {
            var delivery = await _deliveryRepository.FindByOrderIdAsync(command.OrderId);
            delivery.Cancel();
            await _deliveryRepository.UpdateAsync(delivery);
            if (delivery.HasAssignedCourier)
            {
                var courier = await _courierRepository.FindByIdAsync(delivery.CourierId.Value);
                courier.RemoveDelivery(delivery.DeliveryId);
                await _courierRepository.UpdateAsync(courier);
            }
            return Unit.Value;
        }
    }
}
