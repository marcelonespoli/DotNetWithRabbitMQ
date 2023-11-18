using MicroRabbit.Transfer.Domain.Events;
using MicroRabbitMQ.Domain.Core.Bus;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {
            
        }

        public Task Handle(TransferCreatedEvent @event)
        {

            return Task.CompletedTask;
        }
    }
}
