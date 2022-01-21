using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission4JacobDonaldson.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options)
        {

        }
        public DbSet<FormResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(

                new FormResponse
                {
                    MovieId = 1,
                    Category = "Action",
                    Title = "The Dark Night",
                    Year = 2008,
                    DirectorFirstName = "Christopher",
                    DirectorLastName = "Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Ches this is the best!",
                },
                new FormResponse
                {
                    MovieId = 2,
                    Category = "SciFi",
                    Title = "Star Wars Episode III: Revenge of the Sith",
                    Year = 2005,
                    DirectorFirstName = "George",
                    DirectorLastName = "Lucas",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "#r/prequelmemes for life",
                },
                new FormResponse
                {
                    MovieId = 3,
                    Category = "Drama/History",
                    Title = "Valkyrie",
                    Year = 2008,
                    DirectorFirstName = "Bryan",
                    DirectorLastName = "Singer",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "WWII Conspiracy Plot",
                }
                );
                
        }
            
    }
}
