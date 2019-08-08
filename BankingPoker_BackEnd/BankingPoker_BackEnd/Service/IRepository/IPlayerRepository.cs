using BankingPoker_BackEnd.Entity;
using BankingPoker_BackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Service.IRepository
{
    public interface IPlayerRepository
    {
        IQueryable<PlayerViewModel> GetListPlayer();
        void CreatePlayer(Player newPlayer);
        Player GetPlayerById(Guid playerId);
        void DeletePlayer(Guid playerId);
        bool Save();
    }
}
