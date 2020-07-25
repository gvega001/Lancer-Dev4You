using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lancer.Models
{
    public class FreelancerDataContent:DbContext
    {
        public DbSet<BidViewModel> Bids { get; set; }
        public DbSet<BusinessAccountViewModel> BusinessAcounts { get; set; }
        public DbSet<FreeLancerViewModel> FreeLancers { get; set; }
        public DbSet<LeadContactViewModel> LeadContacts { get; set; }
        public DbSet<MilestonesViewModel> Milestones { get; set; }
        public DbSet<OfferViewModel> Offers { get; set; }
        public DbSet<ProjectViewModel> Projects { get; set; }
        public DbSet<RegisterViewModel> Users { get; set; }

    }
}
