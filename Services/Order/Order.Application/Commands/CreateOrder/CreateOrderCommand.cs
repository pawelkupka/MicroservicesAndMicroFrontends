using System;
using System.Collections.Generic;
using MediatR;

namespace Order.Application.Commands.CreateOrder
{
    public record CreateOrderCommand : IRequest
    {
        public CreateOrderCommand(
            Guid consumerId,
            Guid restaurantId,
            DeliveryInformation deliveryInfo,
            PaymentInformation paymentInfo,
            IEnumerable<OrderLineItem> lineItems)
        {
            ConsumerId = consumerId;
            RestaurantId = restaurantId;
            DeliveryInfo = deliveryInfo;
            PaymentInfo = paymentInfo;
            LineItems = lineItems;
        }

        public Guid ConsumerId { get; init; }
        public Guid RestaurantId { get; init; }
        public DeliveryInformation DeliveryInfo { get; init; }
        public PaymentInformation PaymentInfo { get; init; }
        public IEnumerable<OrderLineItem> LineItems { get; init; }

        public record DeliveryInformation(DateTime Time, string Line1, string Line2, string City, string PostalCode);
        public record PaymentInformation(string PaymentToken);
        public record OrderLineItem(int Quantity, long MenuItemId, string Name, decimal Price);
    }
}
