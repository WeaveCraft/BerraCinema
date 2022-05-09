using System.ComponentModel.DataAnnotations;

namespace Berra.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Salon")]
        [Range(1, 2, ErrorMessage = "Display order must be in range of 1-2.")]
        public int DisplayOrder { get; set; }
    }
}
