using System.Threading.Tasks;

namespace Common.Application.Commands
{
    public interface ICommandBus
    {
        Task Send(ICommand command);
    }
}
