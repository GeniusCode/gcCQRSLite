using System.Linq;

namespace GeniusCode.Cqrs
{
    public abstract class CommandHandler<T> : ICommandHandler, ICommandHandler<T> where T : IDomainCommand
    {
        protected virtual bool PerformCanExecute(T command)
        {
            return true;
        }
        
        protected abstract ICommandResult PerformExecute(T command);


        bool ICommandHandler.CanExecute(IDomainCommand command)
        {
            if (command is T)
                return PerformCanExecute((T)command);

            return false;
        }

        ICommandResult ICommandHandler.Execute(IDomainCommand command)
        {
            return PerformExecute((T)command);
        }

        public ICommandResult Execute(T command)
        {
            return PerformExecute(command);
        }
    }
}