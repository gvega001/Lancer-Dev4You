using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Lancer.Models
{
    public class MilestonesViewModel
    {
        [Required]
        public Guid Id { get; private set; } = Guid.NewGuid();
        public bool ShowRequestId => Id != null;
        [Required]
        [DataType(DataType.Currency)]
        public Decimal Amount { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Days To Deliver")]
        public DateTime DaysToDelivery { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Descriptions { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Summary { get; set; }
       
    }
}
