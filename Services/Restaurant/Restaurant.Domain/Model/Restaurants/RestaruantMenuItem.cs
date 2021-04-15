namespace Restaurant.Domain.Model.Restaurants
{
    public record RestaruantMenuItem
    {
        public RestaruantMenuItem(long restaruantMenuItemId, string name, decimal price)
        {
            RestaruantMenuItemId = restaruantMenuItemId;
            Name = name;
            Price = price;
        }

        public long RestaruantMenuItemId { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
    }
}
