using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Delivery.Application.Commands.UpdateCourierAvailability
{
    using Domain.Model.Couriers;

    public class UpdateCourierAvailabilityCommandHandler : IRequestHandler<UpdateCourierAvailabilityCommand>
    {
        private readonly ICourierRepository _courierRepository;

        public UpdateCourierAvailabilityCommandHandler(ICourierRepository courierRepository)
        {
            _courierRepository = courierRepository;
        }

        public async Task<Unit> Handle(UpdateCourierAvailabilityCommand command, CancellationToken cancellationToken)
        {
            var courier = await _courierRepository.FindByIdAsync(command.CourierId);
            if (command.Available)
                courier.MakeAvailable();
            else
                courier.MakeUnavailable();
            await _courierRepository.UpdateAsync(courier);
            return Unit.Value;
        }
    }
}
