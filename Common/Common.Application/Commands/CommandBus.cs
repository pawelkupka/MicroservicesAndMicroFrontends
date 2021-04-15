using MediatR;
using System.Threading.Tasks;

namespace Common.Application.Commands
{
    public class CommandBus : ICommandBus
    {
        private readonly IMediator _mediator;

        public CommandBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Send(ICommand command)
        {
            await _mediator.Send(command);
        }
    }
}
