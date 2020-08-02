using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lancer.Models
{ [Authorize]
    [BindProperties]
    public class BidViewModel
    {
        
        public long Id { get; set; }
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
