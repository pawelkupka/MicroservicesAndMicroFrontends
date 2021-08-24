using FluentValidation;

namespace Delivery.Application.Commands.ScheduleDelivery
{
    public class ScheduleDeliveryCommandValidator : AbstractValidator<ScheduleDeliveryCommand>
    {
        public ScheduleDeliveryCommandValidator()
        {
            RuleFor(order => order.OrderId).NotEmpty();
            RuleFor(order => order.WhenReadyForPickup).NotEmpty();
        }
    }
}
