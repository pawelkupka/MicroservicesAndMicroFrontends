using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Delivery.Application.Queries.GetDeliveryByOrderId
{
    using Domain.Model.Deliveries;

    public class GetDeliveryByOrderIdQueryHandler : IRequestHandler<GetDeliveryByOrderIdQuery, GetDeliveryByOrderIdQueryResult>
    {
        private readonly IDeliveryRepository _deliveryRepository;

        public GetDeliveryByOrderIdQueryHandler(IDeliveryRepository deliveryRepository)
        {
            _deliveryRepository = deliveryRepository;
        }

        public async Task<GetDeliveryByOrderIdQueryResult> Handle(GetDeliveryByOrderIdQuery query, CancellationToken cancellationToken)
        {
            var delivery = await _deliveryRepository.FindByOrderIdAsync(query.OrderId);
            return new GetDeliveryByOrderIdQueryResult(delivery.OrderId);
        }
    }
}
