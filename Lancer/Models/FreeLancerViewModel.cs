using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Lancer.Models
{
    [Authorize]
    [BindProperties]
    public class FreeLancerViewModel
    {
     
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "First Name must be between 3 and 100 characters long")]
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
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mobile no. is required")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string Phone { get; set; }
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 5,
          ErrorMessage = "Address must be between 5 and 100 characters long")]
        public string Address { get; set; }
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 5,
          ErrorMessage = "Cite must be between 5 and 100 characters long")]
        public string City { get; set; }
        [DataType(DataType.Text)]
        [StringLength(3, MinimumLength = 1,
          ErrorMessage = "Address must be between 1 and 100 characters long")]
        public string State { get; set; }
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 5,
          ErrorMessage = "Address must be between 5 and 100 characters long")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        public bool Notifications { get; set; }
        public virtual ICollection<BidViewModel> Bids { get; set; }

    }

}
