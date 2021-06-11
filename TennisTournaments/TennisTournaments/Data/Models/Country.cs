using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Data.Models
{
    public class Country
    {
        public Country()
        {
            this.Players = new HashSet<Player>();
        }
        public int Id { get; set; }

        public string Code { get; set; }

        public string CountryName { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
