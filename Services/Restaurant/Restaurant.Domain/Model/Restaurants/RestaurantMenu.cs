using System.Collections.Generic;

namespace Restaurant.Domain.Model.Restaurants
{
    public record RestaurantMenu
    {
        public RestaurantMenu(IEnumerable<RestaruantMenuItem> items)
        {
            Items = items;
        }

        public IEnumerable<RestaruantMenuItem> Items { get; init; }
    }
}
