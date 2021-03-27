using System.Threading.Tasks;

namespace Delivery.Application.Commands
{
    using Common.Application.Commands;
    using Domain.Model;

    public class UpdateCourierAvailabilityCommandHandler : ICommandHandler
    {
        private readonly ICourierRepository _courierRepository;

        public UpdateCourierAvailabilityCommandHandler(ICourierRepository courierRepository)
        {
            _courierRepository = courierRepository;
        }

        public async Task HandleAsync(UpdateCourierAvailabilityCommand command)
        {
            var courier = await _courierRepository.FindByIdAsync(command.CourierId);
            if (command.Available)
                courier.NoteAvailable();
            else
                courier.NoteUnavailable();
            await _courierRepository.UpdateAsync(courier);
        }
    }
}
