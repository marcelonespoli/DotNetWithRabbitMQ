using MicroRabbitMQ.Banking.Application.Interfaces;
using MicroRabbitMQ.Banking.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbitMQ.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }        
    }
}
