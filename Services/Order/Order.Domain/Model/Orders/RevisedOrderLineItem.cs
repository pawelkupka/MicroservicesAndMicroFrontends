namespace Order.Domain.Model.Orders
{
    public record RevisedOrderLineItem
    {
        public RevisedOrderLineItem(int quantity, long menuItemId)
        {
            Quantity = quantity;
            MenuItemId = menuItemId;
        }

        public int Quantity { get; init; }
        public long MenuItemId { get; init; }
    }
}
