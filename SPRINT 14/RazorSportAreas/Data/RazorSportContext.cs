using Microsoft.EntityFrameworkCore;

namespace RazorSportAreas.Data
{
    public class RazorSportAreasContext : DbContext
    {
        public RazorSportAreasContext (
            DbContextOptions<RazorSportAreasContext> options)
            : base(options) {}
        
        public DbSet<RazorSportAreas.Models.Atleet> Atleet { get; set; }
    }
}