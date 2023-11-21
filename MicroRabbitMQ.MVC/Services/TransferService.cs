using MicroRabbitMQ.MVC.DTO;
using Newtonsoft.Json;

namespace MicroRabbitMQ.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;

        public TransferService(HttpClient httpClient)
        {
            _apiClient = httpClient;
        }

        public async Task Transfer(TransferDto transferDto)
        {
            var uri = "https://localhost:7188/api/banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto),
                                            System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
