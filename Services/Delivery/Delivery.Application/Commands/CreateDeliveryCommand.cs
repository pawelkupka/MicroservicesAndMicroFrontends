using System;
using MediatR;

namespace Delivery.Application.Commands
{
    public record CreateDeliveryCommand : IRequest
    {
        public Guid OrderId { get; init; }
        public Guid ResturantId { get; init; }
        public string Line1 { get; init; }
        public string Line2 { get; init; }
        public string City { get; init; }
        public string PostalCode { get; init; }
    }
}
