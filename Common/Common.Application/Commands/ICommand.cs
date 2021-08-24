using MediatR;

namespace Common.Application.Commands
{
    public interface ICommand<out TCommandResult> : IRequest<TCommandResult>
    {
    }
}
