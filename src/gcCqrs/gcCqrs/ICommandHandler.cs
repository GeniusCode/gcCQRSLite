using System.Linq;

namespace GeniusCode.Cqrs.Commands
{
    public interface ICommandHandler
    {
        bool CanExecute(IDomainCommand command);
        CommandResult Execute(IDomainCommand command);
    }

    public interface ICommandHandler<in T>
     where T : IDomainCommand
    {
        CommandResult Execute(T command);
    }
}
