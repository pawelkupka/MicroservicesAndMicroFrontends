using MediatR;

namespace Common.Application.Commands
{
    public interface ICommandHandler<in TRequest> : IRequestHandler<TRequest, Unit> where TRequest : ICommand
    {
    }
}
