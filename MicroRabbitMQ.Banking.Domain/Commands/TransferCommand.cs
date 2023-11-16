using MicroRabbitMQ.Domain.Core.Commands;

namespace MicroRabbitMQ.Banking.Domain.Commands
{
    public abstract class TransferCommand : Command
    {
        public int From { get; set; }
        public int To { get; set; }
        public decimal Amount { get; set; }
    }
}
