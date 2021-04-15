using System.Collections.Generic;
using System.Linq;

namespace Order.Domain.Model.Orders
{
    public class OrderLineItems
    {
        public OrderLineItems(IEnumerable<OrderLineItem> lineItems)
        {
            LineItems = lineItems;
        }

        public IEnumerable<OrderLineItem> LineItems { get; }

        public decimal OrderTotal()
        {
            return LineItems.Sum(x => x.Total());
        }

        public void Update(OrderRevision orderRevision)
        {
            orderRevision.RevisedOrderLineItems.ToList().ForEach(revisedItem => 
                LineItems.FirstOrDefault(item => item.MenuItemId == revisedItem.MenuItemId)?.UpdateQuantity(revisedItem.Quantity));
        }
    }
}
