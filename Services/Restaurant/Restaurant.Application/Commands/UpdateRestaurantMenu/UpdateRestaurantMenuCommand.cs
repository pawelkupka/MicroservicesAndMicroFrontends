using System;

namespace Restaurant.Application.Commands.UpdateRestaurantMenu
{
    using Domain.Model.Restaurants;

    public class UpdateRestaurantMenuCommand
    {
        public UpdateRestaurantMenuCommand(Guid restaruantId, RestaurantMenu restaurantMenu)
        {
            RestaruantId = restaruantId;
            RestaurantMenu = restaurantMenu;
        }

        public Guid RestaruantId { get; }
        public RestaurantMenu RestaurantMenu { get; }
    }
}
