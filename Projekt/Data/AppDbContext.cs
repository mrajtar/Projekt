using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projekt.Models;
using Projekt.Models.Classes;

namespace Projekt.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<MovieDetails> MovieDetails { get; internal set; }

        public DbSet<Cinema> Cinema { get; internal set; }

        public DbSet<ScreenTime> ScreenTimes { get; internal set; }

        public DbSet<Seat> Seats { get; internal set; }

        public DbSet<ScreenTimeSeats> ScreenTimeSeats { get; internal set; }
    }
}
