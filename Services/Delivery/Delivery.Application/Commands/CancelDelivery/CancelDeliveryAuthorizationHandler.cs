using System.Threading;
using System.Threading.Tasks;

namespace Delivery.Application.Commands.CancelDelivery
{
    using Common.Application.Authorization;
    using Domain.Model.Deliveries;

    public class CancelDeliveryAuthorizationHandler : IAuthorizationHandler<CancelDeliveryCommand>
    {
        private readonly IDeliveryRepository _deliveryRepository;

        public CancelDeliveryAuthorizationHandler(IDeliveryRepository deliveryRepository)
        {
            _deliveryRepository = deliveryRepository;
        }

        public async Task<AuthorizationResult> Handle(CancelDeliveryCommand command, CancellationToken cancellationToken = default)
        {
            var delivery = await _deliveryRepository.FindByOrderIdAsync(command.OrderId);
            return AuthorizationResult.Success();
        }
    }
}
