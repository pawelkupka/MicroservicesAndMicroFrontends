using System;

namespace Delivery.Application.Commands
{
    using Common.Application.Commands;

    public class CancelDeliveryCommand : ICommand
    {
        public CancelDeliveryCommand(Guid orderId)
        {
            OrderId = orderId;
        }

        public Guid OrderId { get; }
    }
}
