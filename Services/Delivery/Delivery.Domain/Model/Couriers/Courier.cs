using System;
using System.Collections.Generic;

namespace Delivery.Domain.Model.Couriers
{
    public class Courier
    {
        public Courier(string name, bool available)
        {
            CourierId = Guid.NewGuid();
            Name = name;
            Available = available;
            DeliveryPlan = new Plan();
        }

        public Guid CourierId { get; }
        public string Name { get; }
        public bool Available { get; private set; }
        public Plan DeliveryPlan { get; }

        public void NoteAvailable()
        {
            Available = true;
        }

        public void NoteUnavailable()
        {
            Available = false;
        }

        public void AddAction(Action action)
        {
            DeliveryPlan.AddAction(action);
        }

        public void RemoveDelivery(Guid deliveryId)
        {
            DeliveryPlan.RemoveDelivery(deliveryId);
        }

        public IEnumerable<Action> ActionsForDelivery(Guid deliveryId)
        {
            return DeliveryPlan.ActionsForDelivery(deliveryId);
        }
    }
}
