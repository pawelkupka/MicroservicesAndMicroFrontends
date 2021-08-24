using MediatR;

namespace Common.Application.Commands
{
    public interface ICommandHandler<in TCommand, TCommandResult> : IRequestHandler<TCommand, TCommandResult> 
        where TCommand : ICommand<TCommandResult>
    {
    }
}
