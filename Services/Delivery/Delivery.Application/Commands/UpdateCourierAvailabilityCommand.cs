using System;

namespace Delivery.Application.Commands
{
    using Common.Application.Commands;

    public class UpdateCourierAvailabilityCommand : ICommand
    {
        public UpdateCourierAvailabilityCommand(Guid courierId, bool available)
        {
            CourierId = courierId;
            Available = available;
        }

        public Guid CourierId { get; }
        public bool Available { get; }
    }
}
