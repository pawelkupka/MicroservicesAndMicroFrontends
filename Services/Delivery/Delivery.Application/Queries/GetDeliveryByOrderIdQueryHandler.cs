using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Delivery.Application.Queries
{
    public class GetDeliveryByOrderIdQueryHandler : IRequestHandler<GetDeliveryByOrderIdQuery, GetDeliveryByOrderIdQueryResult>
    {
        public async Task<GetDeliveryByOrderIdQueryResult> Handle(GetDeliveryByOrderIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
