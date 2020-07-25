using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Lancer.Models
{

    public class LeadViewModel
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set ; }

       
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength =3,
            ErrorMessage ="First Name must be between 3 and 100 characters long")]
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
        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
