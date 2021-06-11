using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Data.Models
{
    public class PlayingIn
    {
        public int Id { get; set; }

        public int RegistrationId { get; set; }

        public Registration Registration { get; set; }

        public int Seed { get; set; }

        public int TournamentPlayingCategoryId { get; set; }

        public TournamentPlayingCategory TournamentPlayingCategory { get; set; }
    }
}
