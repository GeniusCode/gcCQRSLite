using System.Collections.Generic;
using System.Linq;
using GeniusCode.Cqrs.Support;

namespace GeniusCode.Cqrs
{
    public class RoutingCommandAgent : ICommandAgent
    {
        private readonly List<ICommandHandler> _handlers;

        public RoutingCommandAgent(IEnumerable<ICommandHandler> handlers)
        {
            _handlers = handlers.ToList();
        }

        protected virtual void OnBeforeRouteCommand(DomainCommandEnvelope command)
        {
        }

        protected virtual void OnBeforeExecuteCommandHandler(ICommandHandler handler, IDomainCommand command)
        {
        }

        public ICommandResult SendCommandEnvelope(DomainCommandEnvelope command)
        {
            OnBeforeRouteCommand(command);
            var itemsToExecute = _handlers.Where(t => t.CanExecute(command.Command)).ToList();
            var toExecute = itemsToExecute.SingleOrDefault();

            if (toExecute == null)
                throw new CommandHandlerNotFoundException(command.Command, _handlers, itemsToExecute);

            OnBeforeExecuteCommandHandler(toExecute,command.Command);
            return toExecute.Execute(command.Command);
        }

    }
}
