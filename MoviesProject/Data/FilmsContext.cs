using Microsoft.EntityFrameworkCore;
using MoviesProject.Data.Entities;
namespace MoviesProject.Data
{
    public class FilmsContext:DbContext
    {         

        public FilmsContext(DbContextOptions options) : base(options)
        {

        }
        public  DbSet<Film>  Films { get; set; }    
        public DbSet<Producers> Producers { get; set; } 

    }
}
