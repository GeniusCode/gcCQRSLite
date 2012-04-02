using System.Linq;

namespace GeniusCode.Cqrs.Commands
{
    public abstract class CommandHandler<T> : ICommandHandler, ICommandHandler<T> where T : IDomainCommand
    {
        protected virtual bool PerformCanExecute(T command)
        {
            return true;
        }
        protected abstract CommandResult PerformExecute(T command);


        bool ICommandHandler.CanExecute(IDomainCommand command)
        {
            if (command is T)
                return PerformCanExecute((T)command);

            return false;
        }

        CommandResult ICommandHandler.Execute(IDomainCommand command)
        {
            return PerformExecute((T)command);
        }

        public CommandResult Execute(T command)
        {
            return PerformExecute(command);
        }
    }
}