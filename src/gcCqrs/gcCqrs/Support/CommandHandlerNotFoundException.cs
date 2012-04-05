using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniusCode.Cqrs.Support
{
    /// <summary>
    /// Exception which is thrown when a handler is not found for a domain command, or if too many handlers where found
    /// </summary>
    public class CommandHandlerNotFoundException : Exception, ICommandRoutingException
    {
        /// <summary>
        /// Instance of the command
        /// </summary>
        public IDomainCommand Command { get; set; }

        /// <summary>
        /// Handlers avaialable
        /// </summary>
        public IEnumerable<ICommandHandler> AvailableHandlers { get; set; }


        public override string ToString()
        {
            return "Command Handler could not be found";
        }

        public CommandHandlerNotFoundException(IDomainCommand createCommand,
                                               IEnumerable<ICommandHandler> availaleHandlers)
        {
            Command = createCommand;
            AvailableHandlers = availaleHandlers;
        }

    }
}