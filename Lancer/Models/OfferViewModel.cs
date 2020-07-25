using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Lancer.Models
{
    public class OfferViewModel
    {
        [Required]
        public Guid Id { get; private set; } = Guid.NewGuid();
        public bool ShowRequestId => Id != null;
        [Required]
        public LeadContactViewModel Contact { get; set; }
        [Required]
        public ProjectViewModel Project { get; set; }
        [Required]
        public BidViewModel Bid { get; set; }
        [Required]
        public FreeLancerViewModel FreeLancer { get; set; }
        [Required]
        public BusinessAccountViewModel Business{get; set;}
        List<MilestonesViewModel> MilestonesViews { get; set; }
    }
}
