using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace Lancer.Models
{
    public class BidViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public long Id { get; set; }
        public bool ShowRequestId => Id==0;
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
        [NotMapped]
        public virtual ICollection<FreeLancerViewModel> FreeLancers {get;set;}
        public virtual ICollection<MilestonesViewModel> Milestones { get; set; }

    }
}
