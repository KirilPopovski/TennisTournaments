using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisTournaments.Models;

namespace TennisTournaments.Services
{
    public interface ITournamentsService
    {
        public IEnumerable<TournamentOutputModel> GetAllTournaments();
    }
}
