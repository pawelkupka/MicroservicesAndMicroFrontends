using MediatR;

namespace Delivery.Application.Commands
{
    public record CreateRestaurantCommand : IRequest
    {
        public string Name { get; init; }
        public string Line1 { get; init; }
        public string Line2 { get; init; }
        public string City { get; init; }
        public string PostalCode { get; init; }
    }
}
