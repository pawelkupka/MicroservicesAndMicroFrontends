using System;

namespace Delivery.Domain.Model.Deliveries
{
    public class Delivery
    {
        public Delivery(
            Guid orderId, 
            Guid restaurantId, 
            PickupAddress pickupAddress, 
            DeliveryAddress deliveryAddress)
        {
            DeliveryId = Guid.NewGuid();
            OrderId = orderId;
            RestaurantId = restaurantId;
            PickupAddress = pickupAddress;
            DeliveryAddress = deliveryAddress;
            Status = DeliveryStatus.Pending;
        }

        public Guid DeliveryId { get; }
        public Guid RestaurantId { get; }
        public Guid OrderId { get; }
        public Guid? CourierId { get; private set; }
        public DateTime? WhenReadyForPickup { get; private set; }
        public DateTime? WhenPickedUp { get; private set; }
        public DateTime? WhenDelivered { get; private set; }
        public PickupAddress PickupAddress { get; }
        public DeliveryAddress DeliveryAddress { get; }
        public DeliveryStatus Status { get; private set; }

        public void Schedule(Guid courierId, DateTime whenReadyForPickup)
        {
            CourierId = courierId;
            WhenReadyForPickup = whenReadyForPickup;
            Status = DeliveryStatus.Scheduled;
        }

        public void Cancel()
        {
            CourierId = null;
            Status = DeliveryStatus.Cancelled;
        }
    }
}
