using System;
using System.ComponentModel.DataAnnotations;

namespace Lancer.Models
{
    public class BusinessAccountViewModel
    {
        [Required]
        public Guid Id { get; private set; } = Guid.NewGuid();
        public bool ShowRequestId => Id!=null;
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
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

    }
}
