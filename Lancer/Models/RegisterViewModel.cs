using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Lancer.Models
{

    public class RegisterViewModel
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }


        [Required]
        [EmailAddress, MaxLength(500)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Passwords must match")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

}
