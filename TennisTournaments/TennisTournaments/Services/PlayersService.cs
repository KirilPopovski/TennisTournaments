using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisTournaments.Data;
using TennisTournaments.Models;

namespace TennisTournaments.Services
{
    public class PlayersService : IPlayersService
    {
        private readonly ApplicationDbContext db;

        public PlayersService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<PlayerOutputModel> GetAllPlayers()
        {
            return db.Players.Select(p => new PlayerOutputModel
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                Gender = p.Gender
            }).ToList();
        }
    }
}
