using System;

namespace Delivery.Domain.Model.Deliveries
{
    using Common.Domain.Model;

    public record DeliveryCancelled : IDomainEvent
    {

        public DeliveryCancelled(Guid deliveryId, Guid? courierId, DeliveryStatus status)
        {
            DeliveryId = deliveryId;
            CourierId = courierId;
            Status = status;
        }

        public Guid DeliveryId { get; }
        public Guid? CourierId { get; }
        public DeliveryStatus Status { get; }
    }
}
