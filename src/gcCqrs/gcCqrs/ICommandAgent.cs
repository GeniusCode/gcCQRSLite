using System.Linq;

namespace GeniusCode.Cqrs
{
    public interface ICommandAgent
    {
        /// <summary>
        /// Sends a command envelope
        /// </summary>
        /// <param name="commandEnvelope"></param>
        /// <returns></returns>
        ICommandResult SendCommandEnvelope(DomainCommandEnvelope commandEnvelope);
    }
}