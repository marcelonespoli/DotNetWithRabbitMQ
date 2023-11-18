using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options): base(options)
        {                
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}

// TODO download SQL Server Developer Edition

// migration steps:
// First, set as startup projet the Transfer.API
// In Tools > NuGet Package Manager > Package Manager Console
// select the Transfer.Data project
// Run commands:
// Add-Migration "Initial Migration" -Context TransferDbContext
// Update-Database -Context TransferDbContext