using System.ComponentModel.DataAnnotations;
using KOI_System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KOI_System.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Details { get; set; }
        public string Venue { get; set; }
        public string Date { get; set; }
    }
}
