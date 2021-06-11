using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Data.Models
{
    public class Registration
    {
        public Registration()
        {
            this.RegistrationPlayers = new HashSet<RegistrationPlayer>();
            this.PlayingsIn = new HashSet<PlayingIn>();
            this.FirstFixtures = new HashSet<Fixture>();
            this.SecondFixtures = new HashSet<Fixture>();
            this.FixtureResults = new HashSet<FixtureResult>();
        }
        public int Id { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        public ICollection<RegistrationPlayer> RegistrationPlayers { get; set; }

        public ICollection<PlayingIn> PlayingsIn { get; set; }

        public ICollection<Fixture> FirstFixtures { get; set; }

        public ICollection<Fixture> SecondFixtures { get; set; }

        public ICollection<FixtureResult> FixtureResults { get; set; }
    }
}
