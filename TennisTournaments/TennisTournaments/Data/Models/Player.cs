using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Data.Models
{
    public class Player
    {
        public Player()
        {
            this.RegistrationPlayers = new HashSet<RegistrationPlayer>();
        }
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public ICollection<RegistrationPlayer> RegistrationPlayers{ get; set; }
    }
}
