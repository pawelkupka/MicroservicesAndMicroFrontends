using FluentValidation;

namespace Delivery.Application.Commands.Validators
{
    public class CreateRestaurantCommandValidator : AbstractValidator<CreateRestaurantCommand>
    {
        public CreateRestaurantCommandValidator()
        {
            RuleFor(order => order.Name).NotEmpty();
            RuleFor(order => order.Line1).NotEmpty();
            RuleFor(order => order.Line2).NotEmpty();
            RuleFor(order => order.City).NotEmpty();
            RuleFor(order => order.PostalCode).NotEmpty();
        }
    }
}
