using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Lancer.Models
{
    public class MilestonesViewModel
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public bool ShowRequestId => Id != null;
        public Decimal Amount { get; set; }
        public DateTime DaysToDelivery { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Descriptions { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Summary { get; set; }
       
    }
}
