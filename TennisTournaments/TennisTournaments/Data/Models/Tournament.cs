using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Data.Models
{
    public class Tournament
    {
        public Tournament()
        {
            this.TournamentPlayingCategories = new HashSet<TournamentPlayingCategory>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int NumberOfRounds { get; set; }

        [Required]
        public string SurfaceType { get; set; }

        [Required]
        public string TournamentType { get; set; }

        public ICollection<TournamentPlayingCategory> TournamentPlayingCategories { get; set; }
    }
}
