using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTournaments.Data.Models
{
    public class RegistrationPlayer
    {
        public int Id { get; set; }

        public int RegistrationId { get; set; }

        public Registration Registration { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }
    }
}
