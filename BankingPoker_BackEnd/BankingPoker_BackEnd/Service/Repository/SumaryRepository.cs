using BankingPoker_BackEnd.Entity;
using BankingPoker_BackEnd.Service.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Service.Repository
{
    public class SumaryRepository : ISumaryRepository
    {
        private readonly BankPokerDbContext context;
        public SumaryRepository(BankPokerDbContext context)
        {
            this.context = context;
        }

        public bool Save() {
            return (context.SaveChanges() >= 0);
        }

        public void CreateSumary(Sumary newSumary)
        {
            context.Add(newSumary);
        }

        public IEnumerable<Sumary> GetListSumaryByDate(DateTime date)
        {
            return context.Sumary.Where(x => x.Date == date).ToList();
        }

        public void UpdateSumary(int numberAdd,Guid playerId)
        {
            var sumary = context.Sumary.Where(x => x.PlayerId == playerId).FirstOrDefault();
            sumary.SumAdd += numberAdd;
        }
    }
}
