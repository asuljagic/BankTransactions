using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace BankTransactions.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        {}

        public DbSet<Transaction> Transactions{ get; set; }
    }
}
