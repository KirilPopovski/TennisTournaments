using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Models
{
    public class TournamentOutputModel
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
