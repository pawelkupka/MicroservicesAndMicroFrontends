using System.Threading;
using System.Threading.Tasks;

namespace Common.Application.Validation
{
    public interface IValidationHandler<TRequest> where TRequest : IValidable
    {
        Task<ValidationResult> Handle(TRequest request, CancellationToken cancellationToken = default);
    }
}
