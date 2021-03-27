using System.Threading.Tasks;

namespace Delivery.Application.Commands
{
    using Common.Application.Commands;
    using Domain.Model;

    public class CreateRestaurantCommandHandler : ICommandHandler
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public CreateRestaurantCommandHandler(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public async Task HandleAsync(CreateRestaurantCommand command)
        {
            var address = new Address(command.Street, command.City, command.State, command.Zip);
            await _restaurantRepository.AddAsync(new Restaurant(command.Name, address));
        }
    }
}
