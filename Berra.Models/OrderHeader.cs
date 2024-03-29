﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berra.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime OrderDate { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")] //Curreny display name
        [Display(Name = "Order Total")]
        public double OrderTotal { get; set; }
        public DateTime PickUpTime { get; set; }
        [Required]
        [NotMapped]
        public DateTime MovieDate { get; set; }
        public string Status { get; set; }
        public string? Comments { get; set; }
        public string? TransactionId { get; set; }
        [Display(Name = "Order Name")]
        [Required]
        public string PickupName { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
