using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Delivery.Application.Commands.CancelDelivery
{
    using Domain.Model.Couriers;

    public class CreateCourierCommandHandler : IRequestHandler<CreateCourierCommand>
    {
        private readonly ICourierRepository _courierRepository;

        public CreateCourierCommandHandler(ICourierRepository courierRepository)
        {
            _courierRepository = courierRepository;
        }

        public async Task<Unit> Handle(CreateCourierCommand command, CancellationToken cancellationToken)
        {
            var courier = new Courier(command.Name, command.Available);
            await _courierRepository.AddAsync(courier);
            return Unit.Value;
        }
    }
}
