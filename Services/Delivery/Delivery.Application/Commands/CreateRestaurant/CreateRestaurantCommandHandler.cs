using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Delivery.Application.Commands.CreateRestaurant
{
    using Domain.Model.Restuarants;

    public class CreateRestaurantCommandHandler : IRequestHandler<CreateRestaurantCommand>
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public CreateRestaurantCommandHandler(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public async Task<Unit> Handle(CreateRestaurantCommand command, CancellationToken cancellationToken)
        {
            var address = new RestaurantAddress(command.Line1, command.Line2, command.City, command.PostalCode);
            await _restaurantRepository.AddAsync(new Restaurant(command.Name, address));
            return Unit.Value;
        }
    }
}
