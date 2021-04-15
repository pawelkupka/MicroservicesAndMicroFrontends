using FluentValidation;

namespace Delivery.Application.Commands.Validators
{
    public class UpdateCourierAvailabilityCommandValidator : AbstractValidator<UpdateCourierAvailabilityCommand>
    {
        public UpdateCourierAvailabilityCommandValidator()
        {
            RuleFor(order => order.CourierId).NotEmpty();
            RuleFor(order => order.Available).NotEmpty();
        }
    }
}
