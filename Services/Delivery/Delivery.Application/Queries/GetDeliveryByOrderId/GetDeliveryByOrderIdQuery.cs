using System;
using MediatR;

namespace Delivery.Application.Queries.GetDeliveryByOrderId
{
    using Common.Application.Authorization;
    using Common.Application.Caching;

    public record GetDeliveryByOrderIdQuery : IRequest<GetDeliveryByOrderIdQueryResult>, IAuthorizable, ICacheable
    {
        public string CacheKey => $"GetDeliveryByOrderId-{OrderId}";

        public GetDeliveryByOrderIdQuery(Guid orderId)
        {
            OrderId = orderId;
        }

        public Guid OrderId { get; }
    }
}
