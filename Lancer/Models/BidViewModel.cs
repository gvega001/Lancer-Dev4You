using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lancer.Models
{
    public class BidViewModel
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public bool ShowRequestId => Id != null;
        public Decimal Amount { get; set; }
        public DateTime DaysToDelivery { get; set; }
        public string Descriptions { get; set; }
        public string Message { get; set; }
        public FreeLancerViewModel FreeLancer { get; set; }
        List<MilestonesViewModel> Milestones { get; set; }
    }
}
