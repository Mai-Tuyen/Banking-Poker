using BankingPoker_BackEnd.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Service.IRepository
{
    public interface ISumaryRepository
    {
        void CreateSumary(Sumary newSumary);

        void UpdateSumary(int numberAdd,Guid playerId);
        IEnumerable<Sumary> GetListSumaryByDate(DateTime date);
        bool Save();
    }
}
