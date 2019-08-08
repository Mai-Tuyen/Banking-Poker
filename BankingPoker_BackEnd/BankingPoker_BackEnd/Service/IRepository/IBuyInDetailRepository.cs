using BankingPoker_BackEnd.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Service.IRepository
{
    public interface IBuyInDetailRepository
    {
        IEnumerable<BuyInDetail> GetListBuyInDetailByPlayerId(Guid playerId);
        void CreateBuyInDetail(BuyInDetail newBuyInDetail);
        bool Save();
    }
}
