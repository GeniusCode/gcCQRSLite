using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeniusCode.Cqrs.Messages;

namespace GeniusCode.Cqrs.Workers
{
    public interface IWorker
    {
        void DoWork(IMessage message);
    }
}
