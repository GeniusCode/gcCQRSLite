using System.Collections.Generic;
using System.Linq;

namespace GeniusCode.Cqrs.Support
{
    public interface ICommandRoutingException
    {
        /// <summary>
        /// Instance of the command
        /// </summary>
        IDomainCommand Command { get; }

        /// <summary>
        /// Handlers avaialable
        /// </summary>
        IEnumerable<ICommandHandler> AvailableHandlers { get; } 
    }
}