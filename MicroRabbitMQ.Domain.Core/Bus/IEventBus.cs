using MicroRabbitMQ.Domain.Core.Commands;
using MicroRabbitMQ.Domain.Core.Events;

namespace MicroRabbitMQ.Domain.Core.Bus
{
    public interface IEventBus 
    {
        Task SendCommand<T>(T command) where T : Command;
        void Publish<T>(T @event) where T : Command;
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
