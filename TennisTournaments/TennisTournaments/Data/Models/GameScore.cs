using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Data.Models
{
    public class GameScore
    {
        public int Id { get; set; }

        public int FixtureId { get; set; }

        public Fixture Fixture { get; set; }

        public int SetNumber { get; set; }

        public int GameNumber { get; set; }

        public int FirstRegistrationPoints { get; set; }

        public int SecondRegistrationPoints { get; set; }
    }
}
