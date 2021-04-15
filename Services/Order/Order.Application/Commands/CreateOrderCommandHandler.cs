using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Order.Application.Commands
{
    using Domain.Model.Orders;

    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {
        private readonly IOrderRepository _orderRepository;

        public CreateOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Unit> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            var deliveryInformation = new DeliveryInformation(
                command.DeliveryInfo.Time,
                command.DeliveryInfo.Line1,
                command.DeliveryInfo.Line2,
                command.DeliveryInfo.City,
                command.DeliveryInfo.PostalCode);
            var paymentInformation = new PaymentInformation(
                command.PaymentInfo.PaymentToken);
            var lineItems = command.LineItems.Select(item => new OrderLineItem(item.Quantity, item.MenuItemId, item.Name, item.Price));
            var orderLineItems = new OrderLineItems(lineItems);
            var order = new Order(
                command.ConsumerId,
                command.RestaurantId,
                deliveryInformation,
                paymentInformation,
                orderLineItems);
            await _orderRepository.AddAsync(order);
            return Unit.Value;
        }
    }
}
