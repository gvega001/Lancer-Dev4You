using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lancer.Models
{
    public class OfferViewModel
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public bool ShowRequestId => Id != null;
        public LeadContactViewModel Contact { get; set; }
        public ProjectViewModel Project { get; set; }
        public BidViewModel Bid { get; set; }
        public FreeLancerViewModel FreeLancer { get; set; }
        public BusinessAccountViewModel Business{get; set;}
        List<MilestonesViewModel> MilestonesViews { get; set; }
    }
}
