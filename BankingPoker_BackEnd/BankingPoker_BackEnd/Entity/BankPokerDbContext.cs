using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Entity
{
    public class BankPokerDbContext : DbContext
    {
        //public BankPokerDbContext(DbContextOptions<BankPokerDbContext> options) : base(options)
        //{
        //}

        public DbSet<Player> Player { get; set; }
        public DbSet<BuyInDetail> BuyInDetail { get; set; }
        public DbSet<Sumary> Sumary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            //dbContextOptionsBuilder.UseSqlServer(@"Data Source=192.168.6.153,1433;Database=BankPokerDb;Pooling=false;User Id=bodai_db;password=bo0987dai_db;");
            //dbContextOptionsBuilder.UseSqlServer("Server = 34.87.19.240,1433; Database=BankPokerDb;Trusted_Connection =True;User Id=sa;Password=HUNG1abc");
            dbContextOptionsBuilder.UseSqlServer("Data Source=34.87.19.240,1433;Database=BankPokerDb;Pooling=false;User Id=maituyen;password=12345;");
        }
    }
}
