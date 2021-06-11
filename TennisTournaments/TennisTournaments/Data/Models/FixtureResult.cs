using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Data.Models
{
    public class FixtureResult
    {
        public int Id { get; set; }

        public int FixtureId { get; set; }

        public Fixture Fixture { get; set; }

        public int WinnerRegistrationId { get; set; }

        public Registration WinnerRegistration { get; set; }

        public int NumberOfSetsPlayed { get; set; }

        public bool IsOpponentRetired { get; set; }
    }
}
