using MediatR;
using MicroRabbitMQ.Banking.Domain.Commands;
using MicroRabbitMQ.Banking.Domain.Events;
using MicroRabbitMQ.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbitMQ.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            // log some data
            // save in database somehting here
            
            // public event to RabbitMQ
            _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
            
            return Task.FromResult(true);
        }
    }
}
