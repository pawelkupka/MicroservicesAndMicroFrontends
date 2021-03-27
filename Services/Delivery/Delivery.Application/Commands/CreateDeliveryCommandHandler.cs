using System.Threading.Tasks;

namespace Delivery.Application.Commands
{
    using Common.Application.Commands;
    using Domain.Model;

    public class CreateDeliveryCommandHandler : ICommandHandler
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IRestaurantRepository _restaurantRepository;

        public CreateDeliveryCommandHandler(IDeliveryRepository deliveryRepository, IRestaurantRepository restaurantRepository)
        {
            _deliveryRepository = deliveryRepository;
            _restaurantRepository = restaurantRepository;
        }

        public async Task HandleAsync(CreateDeliveryCommand command)
        {
            var restaurant = await _restaurantRepository.FindByIdAsync(command.ResturantId);
            var deliveryAddress = new Address(command.Street, command.City, command.State, command.Zip);
            await _deliveryRepository.AddAsync(new Delivery(command.OrderId, command.ResturantId, restaurant.Address, deliveryAddress));
        }
    }
}
