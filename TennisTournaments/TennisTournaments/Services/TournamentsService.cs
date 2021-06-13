using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisTournaments.Data;
using TennisTournaments.Models;

namespace TennisTournaments.Services
{
    public class TournamentsService : ITournamentsService
    {
        private readonly ApplicationDbContext db;

        public TournamentsService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<TournamentOutputModel> GetAllTournaments()
        {
            return db.Tournaments.Select(t => new TournamentOutputModel
            {
                Name = t.Name,
                Location = t.Location,
                StartDate = t.StartDate,
                EndDate = t.EndDate,
            });
        }
    }
}
