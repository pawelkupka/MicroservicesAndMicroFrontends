using System;

namespace Delivery.Domain.Model.Deliveries
{
    using Common.Domain.Model;

    public class DeliveryScheduled : IDomainEvent
    {

        public DeliveryScheduled(Guid deliveryId, Guid? courierId, DateTime? whenReadyForPickup, DeliveryStatus status)
        {
            DeliveryId = deliveryId;
            CourierId = courierId;
            WhenReadyForPickup = whenReadyForPickup;
            Status = status;
        }

        public Guid DeliveryId { get; }
        public Guid? CourierId { get; }
        public DateTime? WhenReadyForPickup { get; }
        public DeliveryStatus Status { get; }
    }
}
