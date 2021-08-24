using System;
using MediatR;

namespace Delivery.Application.Commands.CancelDelivery
{
    using Common.Application.Authorization;
    using Common.Application.Validation;

    public record CancelDeliveryCommand : IRequest, IAuthorizable, IValidable
    {
        public Guid OrderId { get; init; }
    }
}
