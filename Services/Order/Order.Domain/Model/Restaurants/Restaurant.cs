using System;
using System.Collections.Generic;
using System.Linq;

namespace Order.Domain.Model.Restaurants
{
    public class Restaurant
    {
        public Restaurant(Guid restaurantId, string name, IEnumerable<MenuItem> menuItems)
        {
            RestaurantId = restaurantId;
            Name = name;
            MenuItems = menuItems;
        }

        public Guid RestaurantId { get; }
        public string Name { get; }
        public IEnumerable<MenuItem> MenuItems { get; }

        public MenuItem FindMenuItem(long menuItemId)
        {
            return MenuItems.FirstOrDefault(menuItem => menuItem.MenuItemId == menuItemId);
        }
    }
}
