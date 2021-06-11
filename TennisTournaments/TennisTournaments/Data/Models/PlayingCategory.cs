using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Data.Models
{
    public class PlayingCategory
    {
        public PlayingCategory()
        {
            this.TournamentPlayingCategories = new HashSet<TournamentPlayingCategory>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<TournamentPlayingCategory> TournamentPlayingCategories { get; set; }
    }
}
