namespace MicroRabbitMQ.Banking.Application.Models
{
    public class AccountTransfer
    {
        public int FromAccout { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
