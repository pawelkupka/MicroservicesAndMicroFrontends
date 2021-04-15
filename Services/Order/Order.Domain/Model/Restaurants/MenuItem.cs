namespace Order.Domain.Model.Restaurants
{
    public record MenuItem
    {
        public long MenuItemId { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
    }
}
