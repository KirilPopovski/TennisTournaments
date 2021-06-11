using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Data.Models
{
    public class TournamentPlayingCategory
    {
        public int Id { get; set; }

        public int TournamentId { get; set; }

        public Tournament Tournament { get; set; }

        public int PlayingCategoryId { get; set; }

        public PlayingCategory PlayingCategory { get; set; }
    }
}
