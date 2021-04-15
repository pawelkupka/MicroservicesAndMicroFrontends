using System;
using MediatR;

namespace Delivery.Application.Commands
{
    public record ScheduleDeliveryCommand : IRequest
    {
        public Guid OrderId { get; init; }
        public DateTime WhenReadyForPickup { get; init; }
    }
}
