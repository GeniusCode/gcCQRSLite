using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniusCode.Cqrs.Handlers
{
    public interface IGeneralCommandHandlerFactory
    {
        IEnumerable<ICommandHandlerInfo> GetCommandHandlerInfos(Type commandType);
    }
}