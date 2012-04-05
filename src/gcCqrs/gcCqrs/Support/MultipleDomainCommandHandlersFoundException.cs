using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniusCode.Cqrs.Support
{
    /// <summary>
    /// Exception which is thrown when multiple domain command handlers are found
    /// </summary>
    public class MultipleDomainCommandHandlersFoundException : Exception, ICommandRoutingException
    {
        public MultipleDomainCommandHandlersFoundException(IDomainCommand command, IEnumerable<ICommandHandler> matchingCommandHandlers, IEnumerable<ICommandHandler> availableHandlers )
        {
            Command = command;
            MatchingCommandHandlers = matchingCommandHandlers;
            AvailableHandlers = availableHandlers;
        }

        public override string ToString()
        {
            return "Multiple Commands Handlers were found";
        }

        /// <summary>
        /// Instance of the command
        /// </summary>
        public IDomainCommand Command { get; set; }

        /// <summary>
        /// Matching command handlers
        /// </summary>
        public IEnumerable<ICommandHandler> MatchingCommandHandlers { get; set; }

        /// <summary>
        /// Availalbe command handlers
        /// </summary>
        public IEnumerable<ICommandHandler> AvailableHandlers { get; set; }
           
    }
}