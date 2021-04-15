using System;

namespace Delivery.Domain.Model.Couriers
{
    public class Action
    {
        public Action(ActionType type, Guid deliveryId, ActionAddress address, DateTime time)
        {
            Type = type;
            DeliveryId = deliveryId;
            Address = address;
            Time = time;
        }

        public ActionType Type { get; }
        public Guid DeliveryId { get; }
        public ActionAddress Address { get; }
        public DateTime Time { get; }

        public bool IsForDelivery(Guid deliveryId)
        {
            return DeliveryId.Equals(deliveryId);
        }

        public static Action MakePickup(Guid deliveryId, ActionAddress address, DateTime time)
        {
            return new Action(ActionType.Pickup, deliveryId, address, time);
        }

        public static Action MakeDropoff(Guid deliveryId, ActionAddress address, DateTime time)
        {
            return new Action(ActionType.Dropoff, deliveryId, address, time);
        }
    }
}
