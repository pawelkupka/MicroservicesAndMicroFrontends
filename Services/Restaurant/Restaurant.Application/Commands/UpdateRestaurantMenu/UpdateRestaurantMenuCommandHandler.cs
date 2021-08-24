using System.Threading.Tasks;

namespace Restaurant.Application.Commands.UpdateRestaurantMenu
{
    using Domain.Model.Restaurants;

    public class UpdateRestaurantMenuCommandHandler
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public UpdateRestaurantMenuCommandHandler(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public async Task HandleAsync(UpdateRestaurantMenuCommand command)
        {
            var restaurant = await _restaurantRepository.FindByIdAsync(command.RestaruantId);
            restaurant.UpdateMenu(command.RestaurantMenu);
            await _restaurantRepository.UpdateAsync(restaurant);
        }
    }
}
