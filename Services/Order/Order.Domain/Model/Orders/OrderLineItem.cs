namespace Order.Domain.Model.Orders
{
    public class OrderLineItem
    {
        public OrderLineItem(int quantity, long menuItemId, string name, decimal price)
        {
            Quantity = quantity;
            MenuItemId = menuItemId;
            Name = name;
            Price = price;
        }

        public int Quantity { get; private set; }
        public long MenuItemId { get; }
        public string Name { get; }
        public decimal Price { get; }

        public decimal Total()
        {
            return Quantity * Price;
        }

        public void UpdateQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }
}
