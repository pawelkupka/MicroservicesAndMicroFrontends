using System;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Domain.Model
{
    public class DeliveryPlan
    {
        public DeliveryPlan()
        {
            Actions = new List<DeliveryAction>();
        }

        public List<DeliveryAction> Actions { get; }

        public void AddAction(DeliveryAction action)
        {
            Actions.Append(action);
        }

        public void RemoveDelivery(Guid deliveryId)
        {
            Actions.RemoveAll(action => action.IsForDelivery(deliveryId));
        }

        public IEnumerable<DeliveryAction> ActionsForDelivery(Guid deliveryId)
        {
            return Actions.Where(action => action.IsForDelivery(deliveryId));
        }
    }
}
