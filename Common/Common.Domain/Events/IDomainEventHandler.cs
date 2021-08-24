using System.Threading.Tasks;

namespace Common.Domain.Events
{
    public interface IDomainEventHandler<in TDomainEvent> where TDomainEvent : IDomainEvent
    {
        Task HandleAsync(TDomainEvent @event);
    }
}
