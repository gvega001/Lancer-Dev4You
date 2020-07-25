using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lancer.Models
{
    public class OfferViewModel
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public bool ShowRequestId => Id == 0;
        [Required]
        public LeadContactViewModel Lead { get; set; }
        [Required]
        public ProjectViewModel Project { get; set; }
 
        public virtual ICollection<BidViewModel> Bids { get; set; }
        [Required]
        public FreeLancerViewModel FreeLancers { get; set; }
        [Required]
        public BusinessAccountViewModel Business { get; set; }
        public virtual ICollection<MilestonesViewModel> Milestones { get; set; }
    }
}
