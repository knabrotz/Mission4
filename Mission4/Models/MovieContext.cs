using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        // Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {
            //Leave blank
        }

        public DbSet<MovieEntry> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieEntry>().HasData(
                new MovieEntry
                {
                    MovieID = 1,
                    Category = "Drama",
                    Title = "High School Musical",
                    Year = 2006,
                    Director = "Kenny Ortega",
                    Rating = "G",
                },
                new MovieEntry
                {
                    MovieID = 2,
                    Category = "Musical",
                    Title = "tick, tick...BOOM!",
                    Year = 2021,
                    Director = "Lin-Manuel Miranda",
                    Rating = "PG-13",
                },
                new MovieEntry
                {
                    MovieID = 3,
                    Category = "Animation",
                    Title = "Tangled",
                    Year = 2010,
                    Director = "Nathan Greno",
                    Rating = "PG",
                }
            ); 
        }
    }
}
