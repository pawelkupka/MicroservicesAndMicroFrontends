using System;
using MediatR;

namespace Delivery.Application.Queries
{
    public record GetDeliveryByOrderIdQuery : IRequest<GetDeliveryByOrderIdQueryResult>
    {
        public GetDeliveryByOrderIdQuery(Guid orderId)
        {
            OrderId = orderId;
        }

        public Guid OrderId { get; }
    }
}
