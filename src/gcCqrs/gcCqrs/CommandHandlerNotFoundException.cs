using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniusCode.Cqrs.Commands
{
    public class CommandHandlerNotFoundException : Exception
    {
        public IDomainCommand Command { get; set; }
        public IEnumerable<ICommandHandler> Handlers { get; set; }
        public IEnumerable<ICommandHandler> ToExecuteItems { get; set; }

        public override string ToString()
        {
            return "Command Handler could not be found";
        }

        public CommandHandlerNotFoundException(IDomainCommand createCommand, IEnumerable<ICommandHandler> handlers, IEnumerable<ICommandHandler> toExecuteItems)
        {
            Command = createCommand;
            Handlers = handlers;
            ToExecuteItems = toExecuteItems;
        }
    }
}