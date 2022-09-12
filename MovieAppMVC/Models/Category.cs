using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAppMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Column(TypeName ="varchar")]
        public String CategoryName { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
