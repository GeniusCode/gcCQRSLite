using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniusCode.Cqrs.Handlers
{
    public interface ICommandHandlerInfo
    {
        Type OriginalType { get; }
        IDictionary<string, object> HandlerMetadata { get; }
        void Handle(object toHandle);
    }
}