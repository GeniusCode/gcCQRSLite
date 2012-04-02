using System.Linq;

namespace GeniusCode.Cqrs
{
    public class CommandResult : ICommandResult
    {
        public int CorrelationId { get; set; }
        public bool WasSuccessful { get; set; }
    }
}