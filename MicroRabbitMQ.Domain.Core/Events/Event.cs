namespace MicroRabbitMQ.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timestemp { get; protected set; }

        protected Event()
        {
            Timestemp = DateTime.Now;
        }
    }
}
