using System;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Domain.Model.Couriers
{
    public class Plan
    {
        public Plan()
        {
            Actions = new List<Action>();
        }

        public List<Action> Actions { get; }

        public void AddAction(Action action)
        {
            Actions.Append(action);
        }

        public void RemoveDelivery(Guid deliveryId)
        {
            Actions.RemoveAll(action => action.IsForDelivery(deliveryId));
        }

        public IEnumerable<Action> ActionsForDelivery(Guid deliveryId)
        {
            return Actions.Where(action => action.IsForDelivery(deliveryId));
        }
    }
}
