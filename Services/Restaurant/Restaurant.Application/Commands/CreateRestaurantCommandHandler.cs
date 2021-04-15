using System.Threading.Tasks;

namespace Restaurant.Application.Commands
{
    using Domain.Model.Restaurants;

    public class CreateRestaurantCommandHandler
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public CreateRestaurantCommandHandler(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public async Task HandleAsync(CreateRestaurantCommand command)
        {
            var restaurant = new Restaurant(command.Name, command.Address, command.RestaurantMenu);
            await _restaurantRepository.AddAsync(restaurant);
        }
    }
}
