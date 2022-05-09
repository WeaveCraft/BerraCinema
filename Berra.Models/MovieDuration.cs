using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berra.Models
{
    public class MovieDuration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Movie Duration")]
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime Date { get; set; }
    }
}
