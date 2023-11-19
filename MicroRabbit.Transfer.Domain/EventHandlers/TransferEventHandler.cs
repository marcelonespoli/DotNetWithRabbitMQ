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
            // her we can do calculations
            // talk to another Api or servie
            // save data in teh database

            return Task.CompletedTask;
        }
    }
}
