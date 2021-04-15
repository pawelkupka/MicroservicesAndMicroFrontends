using System.Collections.Generic;

namespace Order.Domain.Model.Orders
{
    public class OrderRevision
    {
        public OrderRevision(
            DeliveryInformation deliveryInformation, 
            IEnumerable<RevisedOrderLineItem> revisedOrderLineItems)
        {
            DeliveryInformation = deliveryInformation;
            RevisedOrderLineItems = revisedOrderLineItems;
        }

        public DeliveryInformation DeliveryInformation { get; }
        public IEnumerable<RevisedOrderLineItem> RevisedOrderLineItems { get; }
    }
}
