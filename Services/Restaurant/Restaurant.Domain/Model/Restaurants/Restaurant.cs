using System;

namespace Restaurant.Domain.Model.Restaurants
{
    public class Restaurant
    {
        public Restaurant(string name, RestaurantAddress address, RestaurantMenu menu)
        {
            RestaurantId = Guid.NewGuid();
            Name = name;
            Address = address;
            Menu = menu;
        }

        public Guid RestaurantId { get; }
        public string Name { get; }
        public RestaurantAddress Address { get; }
        public RestaurantMenu Menu { get; private set; }

        public void UpdateMenu(RestaurantMenu menu)
        {
            Menu = menu;
        }
    }
}
