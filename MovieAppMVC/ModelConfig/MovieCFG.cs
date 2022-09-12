using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieAppMVC.ModelConfig
{
    public class MovieCFG : IEntityTypeConfiguration<Movie>
    {
        private int _;

        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(
                new Movie { Id=1, MovieName="Lord Of The Rings I - The Fellowship of the Ring", CategoryId=1, Director= "Peter Jackson", Duration= 180, ReleasedYear=2001},
                new Movie { Id=2, MovieName= "Top Gun: Maverick", CategoryId=5, Director= "Joseph Kosinski", Duration= 131, ReleasedYear = 2022},
                new Movie { Id=3, MovieName= "Don't Look Up", CategoryId=4, Director= "Adam McKay", Duration= 145, ReleasedYear = 2021},
                new Movie { Id=4, MovieName="The Hunt", CategoryId=2, Director= "Julius Berg", Duration= 92, ReleasedYear = 2020},
                new Movie { Id=5, MovieName= "Harry Potter and the Chamber of Secrets ", CategoryId=1, Director= "Chris Columbus", Duration= 161, ReleasedYear = 2002}
                );
        }
    }
}
