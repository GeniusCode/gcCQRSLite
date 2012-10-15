using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeniusCode.Cqrs.Messages
{
    public interface IMessage
    {
        object Body { get; }
        IDictionary<string, object> Metadata { get; } 
    }
}
