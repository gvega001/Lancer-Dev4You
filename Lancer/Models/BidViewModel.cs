using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Lancer.Models
{
    public class BidViewModel
    {
        [Required]
        public Guid Id { get; private set; } = Guid.NewGuid();
        public bool ShowRequestId => Id != null;
        [Required]
        [DataType(DataType.Currency)]
        public Decimal Amount { get; set; }
        [Required]
        [DataType(DataType.DateTime)]

        [Display(Name = "Days To Delivery")]
        public DateTime DaysToDelivery { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Descriptions { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
        [Required]
        public FreeLancerViewModel FreeLancer { get; set; }
        List<MilestonesViewModel> Milestones { get; set; }
    }
}
