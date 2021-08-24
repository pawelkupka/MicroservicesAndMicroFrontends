using FluentValidation;

namespace Delivery.Application.Commands.CreateDelivery
{
    public class CreateDeliveryCommandValidator : AbstractValidator<CreateDeliveryCommand>
    {
        public CreateDeliveryCommandValidator()
        {
            RuleFor(order => order.OrderId).NotEmpty();
            RuleFor(order => order.ResturantId).NotEmpty();
            RuleFor(order => order.Line1).NotEmpty();
            RuleFor(order => order.Line2).NotEmpty();
            RuleFor(order => order.City).NotEmpty();
            RuleFor(order => order.PostalCode).NotEmpty();
        }
    }
}
