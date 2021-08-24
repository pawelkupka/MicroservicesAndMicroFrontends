using System.Threading;
using System.Threading.Tasks;

namespace Delivery.Application.Queries.GetDeliveryByOrderId
{
    using Common.Application.Authorization;
    using Domain.Model.Deliveries;

    public class GetDeliveryByOrderIdAuthorizationHandler : IAuthorizationHandler<GetDeliveryByOrderIdQuery>
    {
        private readonly IDeliveryRepository _deliveryRepository;

        public GetDeliveryByOrderIdAuthorizationHandler(IDeliveryRepository deliveryRepository)
        {
            _deliveryRepository = deliveryRepository;
        }

        public async Task<AuthorizationResult> Handle(GetDeliveryByOrderIdQuery query, CancellationToken cancellationToken = default)
        {
            var delivery = await _deliveryRepository.FindByOrderIdAsync(query.OrderId);
            return AuthorizationResult.Success();
        }
    }
}
