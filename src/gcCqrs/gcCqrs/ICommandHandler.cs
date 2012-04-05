using System.Linq;

namespace GeniusCode.Cqrs
{
    /// <summary>
    /// General version of the Command Handler interface
    /// </summary>
    public interface ICommandHandler
    {
        /// <summary>
        /// Returns or not the command can be handled
        /// </summary>
        /// <param name="command"></param>
        /// <returns>boolean value</returns>
        bool CanExecute(IDomainCommand command);

        /// <summary>
        /// Executes the command
        /// </summary>
        /// <param name="command"></param>
        /// <returns>a command result</returns>
        ICommandResult Execute(IDomainCommand command);
    }

    /// <summary>
    /// Generics version of the Command Handler interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICommandHandler<in T>
     where T : IDomainCommand
    {
        /// <summary>
        /// Executes the command
        /// </summary>
        /// <param name="command"></param>
        /// <returns>command result</returns>
        ICommandResult Execute(T command);
    }
}
