using System.Threading.Tasks;

namespace Delivery.Application.Commands
{
    using Common.Application.Commands;
    using Domain.Model;

    public class CreateCourierCommandHandler : ICommandHandler
    {
        private readonly ICourierRepository _courierRepository;

        public CreateCourierCommandHandler(ICourierRepository courierRepository)
        {
            _courierRepository = courierRepository;
        }

        public async Task HandleAsync(CreateCourierCommand command)
        {
            var courier = new Courier(command.Name, command.Available);
            await _courierRepository.AddAsync(courier);
        }
    }
}
