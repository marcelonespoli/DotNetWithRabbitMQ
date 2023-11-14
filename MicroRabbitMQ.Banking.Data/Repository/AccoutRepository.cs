using MicroRabbitMQ.Banking.Data.Context;
using MicroRabbitMQ.Banking.Domain.Interfaces;
using MicroRabbitMQ.Banking.Domain.Models;

namespace MicroRabbitMQ.Banking.Data.Repository
{
    public class AccoutRepository : IAccountRepository
    {
        private readonly BankingDbContext _context;

        public AccoutRepository(BankingDbContext context)
        {
                _context = context;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}
