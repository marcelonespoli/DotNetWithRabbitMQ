using MicroRabbitMQ.MVC.DTO;

namespace MicroRabbitMQ.MVC.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto transferDto);
    }
}
