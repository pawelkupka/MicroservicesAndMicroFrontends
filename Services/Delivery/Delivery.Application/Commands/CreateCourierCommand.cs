using MediatR;

namespace Delivery.Application.Commands
{
    public record CreateCourierCommand : IRequest
    {
        public string Name { get; init; }
        public bool Available { get; init; }
    }
}
