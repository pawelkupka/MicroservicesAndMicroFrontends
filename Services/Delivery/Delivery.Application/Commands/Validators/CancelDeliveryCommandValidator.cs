using FluentValidation;

namespace Delivery.Application.Commands.Validators
{
    public class CancelDeliveryCommandValidator : AbstractValidator<CancelDeliveryCommand>
    {
        public CancelDeliveryCommandValidator()
        {
            RuleFor(order => order.OrderId).NotEmpty();
        }
    }
}
