using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Data.Models
{
    public class Fixture
    {
        public Fixture()
        {
            this.SetScores = new HashSet<SetScore>();
            this.GameScores = new HashSet<GameScore>();
            this.TieBreakers = new HashSet<TieBreaker>();
            this.FixtureResults = new HashSet<FixtureResult>();
        }
        public int Id { get; set; }

        public int TournamentPlayingCategoryId { get; set; }

        public TournamentPlayingCategory TournamentPlayingCategory { get; set; }

        public int FirstRegistrationId { get; set; }

        public Registration FirstRegistration { get; set; }

        public int SecondRegistrationId { get; set; }

        public Registration SecondRegistration { get; set; }

        public int Round { get; set; }

        public ICollection<SetScore> SetScores { get; set; }

        public ICollection<GameScore> GameScores { get; set; }

        public ICollection<TieBreaker> TieBreakers { get; set; }

        public ICollection<FixtureResult> FixtureResults { get; set; }
    }
}
