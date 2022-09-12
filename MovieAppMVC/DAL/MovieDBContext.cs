global using MovieAppMVC.Models;
using Microsoft.EntityFrameworkCore;
using MovieAppMVC.ModelConfig;

namespace MovieAppMVC.DAL
{
    public class MovieDBContext:DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options ):base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Movie>(new MovieCFG());
            modelBuilder.ApplyConfiguration<Category>(new CategoryCFG());
        }
    }
}
