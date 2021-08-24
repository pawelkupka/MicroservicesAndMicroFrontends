using FluentValidation;

namespace Delivery.Application.Commands.CancelDelivery
{
    public class CreateCourierCommandValidator : AbstractValidator<CreateCourierCommand>
    {
        public CreateCourierCommandValidator()
        {
            RuleFor(order => order.Name).NotEmpty();
            RuleFor(order => order.Available).NotEmpty();
        }
    }
}
