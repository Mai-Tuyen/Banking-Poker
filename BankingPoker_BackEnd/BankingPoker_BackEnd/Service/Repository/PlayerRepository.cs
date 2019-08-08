using BankingPoker_BackEnd.Entity;
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

        public IEnumerable<Player> GetListPlayer()
        {
            return context.Player.ToList();
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
