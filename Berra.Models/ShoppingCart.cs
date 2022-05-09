using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Berra.Models
{
    public class ShoppingCart
    {
		public ShoppingCart()
		{
			Count = 1; //Start value of cart is set to 1.
		}
		public int Id { get; set; }
		public int MenuItemId { get; set; }
		[ForeignKey("MenuItemId")]
		[ValidateNever]
		public MenuItem MenuItem { get; set; }

		[Range(1, 12, ErrorMessage = "Please select a count between 1 and 12")]
		public int Count { get; set; }
		public string ApplicationUserId { get; set; }
		[ForeignKey("ApplicationUserId")]
		[ValidateNever]
		public ApplicationUser ApplicationUser { get; set; }

	}
}
