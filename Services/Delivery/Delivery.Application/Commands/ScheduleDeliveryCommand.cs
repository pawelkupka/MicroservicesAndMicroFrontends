using System;

namespace Delivery.Application.Commands
{
    using Common.Application.Commands;

    public class ScheduleDeliveryCommand : ICommand
    {
        public ScheduleDeliveryCommand(Guid orderId, DateTime whenReadyForPickup)
        {
            OrderId = orderId;
            WhenReadyForPickup = whenReadyForPickup;
        }

        public Guid OrderId { get; }
        public DateTime WhenReadyForPickup { get; }
    }
}
