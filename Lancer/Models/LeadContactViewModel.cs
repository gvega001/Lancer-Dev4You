using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace Lancer.Models
{
    public class LeadContactViewModel
    {   [Required]
        public Guid Id { get; private set; } = Guid.NewGuid();
        public bool ShowRequestId => Id!=null;
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 3,
           ErrorMessage = "Last Name must be between 3 and 100 characters long")]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 3,
           ErrorMessage = "Last Name must be between 3 and 100 characters long")]
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
        [Required]
        [DataType(DataType.Text)]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string City { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string State { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string ZipCode { get; set; }
        public bool Notifications { get; set; }
        [Required]
        public BusinessAccountViewModel BusinessAccount { get; set; }

    }
}
