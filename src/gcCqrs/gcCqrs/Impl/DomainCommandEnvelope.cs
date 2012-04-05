using System.Linq;

namespace GeniusCode.Cqrs
{
    public class DomainCommandEnvelope
    {
        public string InvokingUserName { get; set; }
        public IDomainCommand Command { get; set; }
    }
}