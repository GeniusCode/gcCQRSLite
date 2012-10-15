using System.Collections.Generic;
using System.Linq;

namespace GeniusCode.Cqrs.Handlers
{
    public interface IGenericCommandHandlerFactory
    {
        IEnumerable<ICommandHandlerInfo> GetCommandHandlerInfos<T>();
    }
}