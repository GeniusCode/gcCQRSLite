using System.Linq;

namespace GeniusCode.Cqrs.Handlers
{
    public interface ICommandHandler<in T>
    {
        void Handle(T command);
    }
}
