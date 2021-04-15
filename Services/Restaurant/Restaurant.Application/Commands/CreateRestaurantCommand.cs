namespace Restaurant.Application.Commands
{
    using Domain.Model.Restaurants;

    public class CreateRestaurantCommand
    {
        public CreateRestaurantCommand(string name, RestaurantAddress address, RestaurantMenu restaurantMenu)
        {
            Name = name;
            Address = address;
            RestaurantMenu = restaurantMenu;
        }

        public string Name { get; }
        public RestaurantAddress Address { get; }
        public RestaurantMenu RestaurantMenu { get; }
    }
}
