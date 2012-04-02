using System.Linq;

namespace GeniusCode.Cqrs
{
    public interface ICommandAgent
    {
        ICommandResult SendCommandEnvelope(DomainCommandEnvelope commandEnvelope);

    }
}