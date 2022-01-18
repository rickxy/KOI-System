
using KOI_System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KOI_System.Models
{
    public class Organizer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public ICollection<seminars> Seminars { get; set;  }

        public ICollection<Events> Events { get; set; }
    }
}