using System;

namespace Delivery.Domain.Model.Deliveries
{
    using Common.Domain.Model;

    public record DeliveryCreated : IDomainEvent
    {
        public DeliveryCreated(
            Guid deliveryId,
            Guid orderId,
            Guid restaurantId,
            DeliveryPickupAddress pickupAddress,
            DeliveryAddress deliveryAddress,
            DeliveryStatus status)
        {
            DeliveryId = deliveryId;
            OrderId = orderId;
            RestaurantId = restaurantId;
            PickupAddress = pickupAddress;
            DeliveryAddress = deliveryAddress;
            Status = status;
        }

        public Guid DeliveryId { get; }
        public Guid RestaurantId { get; }
        public Guid OrderId { get; }
        public DeliveryPickupAddress PickupAddress { get; }
        public DeliveryAddress DeliveryAddress { get; }
        public DeliveryStatus Status { get; private set; }
    }
}
