namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public string AccountFrom { get; set; }
        public string AccountTo { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
