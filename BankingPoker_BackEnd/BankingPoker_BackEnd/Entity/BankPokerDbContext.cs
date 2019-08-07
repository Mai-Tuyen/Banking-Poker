using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Entity
{
    public class BankPokerDbContext : DbContext
    {
        public BankPokerDbContext(DbContextOptions<BankPokerDbContext> options) : base(options)
        {
        }

        public DbSet<Player> Player { get; set; }
        public DbSet<BuyInDetail> BuyInDetail { get; set; }
        public DbSet<Sumary> Sumary { get; set; }
    }
}
