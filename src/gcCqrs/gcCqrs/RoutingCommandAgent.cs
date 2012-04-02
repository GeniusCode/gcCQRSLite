using System.Collections.Generic;
using System.Linq;

namespace GeniusCode.Cqrs
{
    public class RoutingCommandAgent : ICommandAgent
    {
        private readonly IEnumerable<ICommandHandler> _handlers;

        public RoutingCommandAgent(IEnumerable<ICommandHandler> handlers)
        {
            _handlers = handlers;
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

            var toExecuteItems = (from t in _handlers.ToList()
                                  where t.CanExecute(command.Command)
                                  select t).ToList();

            var toExecute = toExecuteItems.SingleOrDefault();

            if (toExecute == null)
                throw new CommandHandlerNotFoundException(command.Command, _handlers, toExecuteItems);

            OnBeforeExecuteCommandHandler(toExecute,command.Command);
            return toExecute.Execute(command.Command);
        }

    }
}
