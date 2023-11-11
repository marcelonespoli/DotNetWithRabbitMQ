using MicroRabbitMQ.Domain.Core.Events;

namespace MicroRabbitMQ.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestemp { get; protected set; }
        
        protected Command()
        {
            Timestemp = DateTime.Now;
        }
    }
}
