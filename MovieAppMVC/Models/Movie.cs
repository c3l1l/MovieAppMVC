using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAppMVC.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Movie name can not be empty !")]
        [StringLength(100)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }
        [StringLength(100)]
        [Column(TypeName = "varchar")]
        public string Director { get; set; }
        public int Duration { get; set; }
        [Display(Name = "Released Year")]
        public int ReleasedYear { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
     
        public Category? Category { get; set; }
    }
}
