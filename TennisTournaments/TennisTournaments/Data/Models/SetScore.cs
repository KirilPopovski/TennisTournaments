using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Data.Models
{
    public class SetScore
    {
        public int Id { get; set; }

        public int FixtureId { get; set; }

        public Fixture Fixture { get; set; }

        public int SetNumber { get; set; }

        public int FirstRegistrationGames { get; set; }

        public int SecondRegistrationGames { get; set; }
    }
}
