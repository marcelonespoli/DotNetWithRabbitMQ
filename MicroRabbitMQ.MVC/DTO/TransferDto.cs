namespace MicroRabbitMQ.MVC.DTO
{
    public class TransferDto
    {
        public int FromAccout { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
