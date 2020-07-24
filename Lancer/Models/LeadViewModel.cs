using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc;
namespace Lancer.Models
{
    [BindProperties]
    public class LeadViewModel
    {
        [Required]
        public Guid Id { get; private set; } = Guid.NewGuid();
        public bool ShowRequestId => Id != null;
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength =3,
            ErrorMessage ="First Name must be between 3 and 100 characters long")]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "Last Name must be between 3 and 100 characters long")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [MinLength(50, ErrorMessage ="The minimum length of the message is 100 characters long")]
        public string Message { get; set; }
    }
}
