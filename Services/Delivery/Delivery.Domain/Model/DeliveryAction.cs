using System;

namespace Delivery.Domain.Model
{
    public class DeliveryAction
    {
        public DeliveryAction(DeliveryActionType type, Guid deliveryId, Address address, DateTime time)
        {
            Type = type;
            DeliveryId = deliveryId;
            Address = address;
            Time = time;
        }

        public DeliveryActionType Type { get; }
        public Guid DeliveryId { get; }
        public Address Address { get; }
        public DateTime Time { get; }

        public bool IsForDelivery(Guid deliveryId)
        {
            return DeliveryId.Equals(deliveryId);
        }

        public static DeliveryAction MakePickup(Guid deliveryId, Address address, DateTime time)
        {
            return new DeliveryAction(DeliveryActionType.Pickup, deliveryId, address, time);
        }

        public static DeliveryAction MakeDropoff(Guid deliveryId, Address address, DateTime time)
        {
            return new DeliveryAction(DeliveryActionType.Dropoff, deliveryId, address, time);
        }
    }
}
