using System.Threading;
using System.Threading.Tasks;

namespace Delivery.Application.Commands.CancelDelivery
{
    using Common.Application.Validation;

    public class CancelDeliveryValidationHandler : IValidationHandler<CancelDeliveryCommand>
    {
        public Task<ValidationResult> Handle(CancelDeliveryCommand command, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
