using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeniusCode.Cqrs
{
    public interface IAggregateRepository<TAggregate>
    {
        /// <summary>
        /// Returns an instance of an aggregate which comes from some data store
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        TAggregate GetAggregateByKey(Guid key);
        /// <summary>
        /// Persists an aggregate to some datastore
        /// </summary>
        /// <param name="aggregate"></param>
        void SaveAggregate(TAggregate aggregate);
    }
}
