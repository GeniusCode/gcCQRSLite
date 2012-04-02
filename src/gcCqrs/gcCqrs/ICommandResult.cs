using System.Linq;

namespace GeniusCode.Cqrs
{
    public interface ICommandResult
    {
        int CorrelationId { get; }
        bool WasSuccessful { get; }
    }
}
