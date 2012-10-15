using System.Collections.Generic;
using System.Linq;

namespace GeniusCode.Cqrs
{
    public interface ICommandAgent
    {
        void SendCommand(object command, IDictionary<string,object> headers);
    }
}