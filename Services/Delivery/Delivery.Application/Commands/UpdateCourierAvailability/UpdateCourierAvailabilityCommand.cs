using System;
using MediatR;

namespace Delivery.Application.Commands.UpdateCourierAvailability
{
    public record UpdateCourierAvailabilityCommand : IRequest
    {
        public Guid CourierId { get; init; }
        public bool Available { get; init; }
    }
}
