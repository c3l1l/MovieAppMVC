using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieAppMVC.ModelConfig
{
    public class CategoryCFG : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id=1, CategoryName="Fantasy"},
                new Category { Id=2, CategoryName="Horror"},
                new Category { Id=3, CategoryName="Adventure"},
                new Category { Id=4, CategoryName="Comedy"},
                new Category { Id=5, CategoryName="Action"},
                new Category { Id=6, CategoryName="Mystery"},
                new Category { Id=7, CategoryName="Thriller"}
                );
        }
    }
}
