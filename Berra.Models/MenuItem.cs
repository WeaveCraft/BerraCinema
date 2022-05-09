using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berra.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [Range(1, 1000, ErrorMessage = "Price should be between 1SEK and 1000SEK")]
        public double Price { get; set; }
        [Display(Name ="Movie Duration")]
        public int MovieDurationId { get; set; }
        [ForeignKey("MovieDurationId")]
        public MovieDuration MovieDuration { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Seats { get; set; } = 100;
    }
}
