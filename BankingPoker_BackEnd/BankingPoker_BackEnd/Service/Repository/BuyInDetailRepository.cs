using BankingPoker_BackEnd.Entity;
using BankingPoker_BackEnd.Service.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Service.Repository
{
    public class BuyInDetailRepository : IBuyInDetailRepository
    {
        private readonly BankPokerDbContext context;
        public BuyInDetailRepository(BankPokerDbContext context)
        {
            this.context = context;
        }
        public void CreateBuyInDetail(BuyInDetail newBuyInDetail)
        {
            context.Add(newBuyInDetail);
        }

        public IEnumerable<BuyInDetail> GetListBuyInDetailByPlayerId(Guid playerId)
        {
            return context.BuyInDetail.Where(x => x.Id == playerId).ToList();
        }

        public bool Save()
        {
            return (context.SaveChanges() >= 0);
        }
    }
}
