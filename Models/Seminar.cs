using System.ComponentModel.DataAnnotations;

namespace KOI_System.Models
{
    public class seminars
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Venue { get; set; }
        public string Date { get; set; }
    }
}
