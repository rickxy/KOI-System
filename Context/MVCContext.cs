using KOI_System.Models;
using Microsoft.EntityFrameworkCore;

namespace KOI_System.Context
{
    public class MVCContext : DbContext
    {
        public MVCContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<seminars> Seminars { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Organizer> Organizers { get; set; }
    }
}
