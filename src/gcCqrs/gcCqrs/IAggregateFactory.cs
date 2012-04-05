using System.Linq;

namespace GeniusCode.Cqrs
{
    public interface IAggregateFactory<out TAggregate>
    {
        /// <summary>
        /// Creates an instance of an aggregate that does not have any internal state
        /// </summary>
        /// <returns></returns>
        TAggregate CreateEmptyAggregate();
    }
}