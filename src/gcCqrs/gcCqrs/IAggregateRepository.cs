using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeniusCode.Cqrs
{
    public interface IAggregateRepository<TAggregate>
    {
        TAggregate GetAggregateByKey(Guid key);
        void SaveAggregate(TAggregate aggregate);
        TAggregate CreateEmptyAggregate();
    }
}
