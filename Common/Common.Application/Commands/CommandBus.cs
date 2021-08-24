using MediatR;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Common.Application.Commands
{
    public class CommandBus : IMediator
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandBus(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task Publish(object notification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default) where TNotification : INotification
        {
            throw new NotImplementedException();
        }

        public async Task<TCommandResult> Send<TCommandResult>(ICommand<TCommandResult> command, CancellationToken cancellationToken = default)
        {
            var handlerType = typeof(ICommandHandler<ICommand<TCommandResult>, TCommandResult>).MakeGenericType(command.GetType());
            var handler = (ICommandHandler<ICommand<TCommandResult>, TCommandResult>)_serviceProvider.GetService(handlerType);
            return await handler.Handle(command, cancellationToken);
        }

        public Task<object> Send(object request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        //public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
