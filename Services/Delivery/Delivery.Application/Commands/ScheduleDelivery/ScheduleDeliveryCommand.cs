using System;
using MediatR;

namespace Delivery.Application.Commands.ScheduleDelivery
{
    public record ScheduleDeliveryCommand : IRequest
    {
        public Guid OrderId { get; init; }
        public DateTime WhenReadyForPickup { get; init; }
    }
}
