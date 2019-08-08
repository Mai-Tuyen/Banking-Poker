using BankingPoker_BackEnd.Entity;
using BankingPoker_BackEnd.Model;
using BankingPoker_BackEnd.Service.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingPoker_BackEnd.Service.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly BankPokerDbContext context;
        public PlayerRepository(BankPokerDbContext context)
        {
            this.context = context;
        }
        public void CreatePlayer(Player newPlayer)
        {
            context.Add(newPlayer);
        }

        public void DeletePlayer(Guid playerId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PlayerViewModel> GetListPlayer()
        {
            var playerViewModels = from a in context.Player
                                   join b in context.Sumary
                                   on a.Id equals b.PlayerId
                                   select new PlayerViewModel()
                                   {
                                       Id = a.Id,
                                       Name = a.Name,
                                       SumAdd = b.SumAdd
                                   };
            return playerViewModels;
        }

        public Player GetPlayerById(Guid playerId)
        {
            return context.Player.Where(x => x.Id.Equals(playerId)).FirstOrDefault();
        }

        public bool Save()
        {
            return (context.SaveChanges() >= 0);
        }
    }
}
