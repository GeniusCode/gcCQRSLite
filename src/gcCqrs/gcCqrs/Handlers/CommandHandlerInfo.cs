using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniusCode.Cqrs.Handlers
{
    public class CommandHandlerInfo<T> : ICommandHandlerInfo
    {
        private readonly Lazy<ICommandHandler<T>> _commandHandler;


        public CommandHandlerInfo(Lazy<ICommandHandler<T>> commandHandler) : this(null, commandHandler)
        {
        }

        public CommandHandlerInfo(IDictionary<string, object> metadata, Lazy<ICommandHandler<T>> commandHandler)
        {
            _commandHandler = commandHandler;
            HandlerMetadata = metadata ?? new Dictionary<string, object>();
        }

        public Type OriginalType { get { return typeof (T); } }
        public IDictionary<string, object> HandlerMetadata { get; private set; }
        public void Handle(object toHandle)
        {
            var handler = _commandHandler.Value;
            handler.Handle((T)toHandle);
        }
    }
}