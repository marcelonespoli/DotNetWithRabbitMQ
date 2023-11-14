using MicroRabbitMQ.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbitMQ.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {                
        }

        public DbSet<Account> Accounts { get; set; }  
    }
}

// TODO download SQL Server Developer Edition

// migration steps:
// First, set as startup projet the Banking.API
// In Tools > NuGet Package Manager > Package Manager Console
// select the Banking.Data project
// Run commands:
// Add-Migration "Initial Migration" -Context BankingDbContext
// Update-Database -Context BankingDbContext