using MediatR;

namespace Delivery.Application.Commands.CancelDelivery
{
    public record CreateCourierCommand : IRequest
    {
        public string Name { get; init; }
        public bool Available { get; init; }
    }
}
