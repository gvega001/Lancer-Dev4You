using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;

namespace Lancer.Models
{
    [Authorize]
    [BindProperties]
    public class LeadContactViewModel
    {
        public long Id { get; set; }

      
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 3,
           ErrorMessage = "Last Name must be between 3 and 100 characters long")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 3,
           ErrorMessage = "Last Name must be between 3 and 100 characters long")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
       
        [DataType(DataType.Text)]
        public string Address { get; set; }
  
        [DataType(DataType.Text)]
        public string City { get; set; }
      
        [DataType(DataType.Text)]
        public string State { get; set; }
     
        [DataType(DataType.Text)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        public bool Notifications { get; set; }
        public virtual ICollection<BusinessAccountViewModel> Businesses { get; set; }
        public BusinessAccountViewModel BusinessAccount { get; set; }

    }
}
