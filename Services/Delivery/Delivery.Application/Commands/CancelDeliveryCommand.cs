using System;
using MediatR;

namespace Delivery.Application.Commands
{
    public record CancelDeliveryCommand : IRequest
    {
        public Guid OrderId { get; init; }
    }
}
