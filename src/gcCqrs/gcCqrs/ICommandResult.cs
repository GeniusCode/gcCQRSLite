using System.Linq;

namespace GeniusCode.Cqrs
{
    /// <summary>
    /// Result of a domain command being executed
    /// </summary>
    public interface ICommandResult
    {
        /// <summary>
        /// Correlation id that somehow references the Key of the aggregate who the command was invoked against
        /// </summary>
        int CorrelationId { get; }
        /// <summary>
        /// Whether or not the command was successfull
        /// </summary>
        bool WasSuccessful { get; }
    }
}
