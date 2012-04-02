using System.Linq;

namespace GeniusCode.Cqrs
{
    public interface ICommandHandler
    {
        bool CanExecute(IDomainCommand command);
        ICommandResult Execute(IDomainCommand command);
    }

    public interface ICommandHandler<in T>
     where T : IDomainCommand
    {
        ICommandResult Execute(T command);
    }
}
