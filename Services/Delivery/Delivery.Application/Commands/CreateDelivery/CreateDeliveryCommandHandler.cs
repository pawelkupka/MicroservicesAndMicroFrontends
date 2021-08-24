using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Delivery.Application.Commands.CreateDelivery
{
    using Domain.Model.Deliveries;
    using Domain.Model.Restuarants;

    public class CreateDeliveryCommandHandler : IRequestHandler<CreateDeliveryCommand>
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IRestaurantRepository _restaurantRepository;

        public CreateDeliveryCommandHandler(IDeliveryRepository deliveryRepository, IRestaurantRepository restaurantRepository)
        {
            _deliveryRepository = deliveryRepository;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<Unit> Handle(CreateDeliveryCommand command, CancellationToken cancellationToken)
        {
            var restaurant = await _restaurantRepository.FindByIdAsync(command.ResturantId);
            var pickupAddress = new DeliveryPickupAddress(restaurant.Address.Line1, restaurant.Address.Line2, restaurant.Address.City, restaurant.Address.PostalCode);
            var deliveryAddress = new DeliveryAddress(command.Line1, command.Line2, command.City, command.PostalCode);
            await _deliveryRepository.AddAsync(new Delivery(command.OrderId, command.ResturantId, pickupAddress, deliveryAddress));
            return Unit.Value;
        }
    }
}
