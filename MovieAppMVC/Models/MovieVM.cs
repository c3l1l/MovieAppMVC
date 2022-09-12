using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MovieAppMVC.Models
{
    public class MovieVM
    {
        [StringLength(100)]
        public string MovieName { get; set; }
        [StringLength(100)]       
        public string Director { get; set; }
        public int Duration { get; set; }
        public int ReleasedYear { get; set; }
        public int CategoryId { get; set; }        
    }
}
