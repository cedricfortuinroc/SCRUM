using System;
using Microsoft.EntityFrameworkCore;

namespace RazorSport.Data
{
    public class RazorSportContext : DbContext
    {
        public RazorSportContext(
            DbContextOptions<RazorSportContext> options)
            : base(options)
        {
        }

        public DbSet<RazorSport.Models.Atleet> Atleet { get; set; }
    }
}