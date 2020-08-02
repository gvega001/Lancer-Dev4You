using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Lancer.Models
{

    public class FreelancerDataContext : IdentityDbContext
    {

        public DbSet<BidViewModel> Bids { get; set; }
        public DbSet<BusinessAccountViewModel> BusinessAcounts { get; set; }
        public DbSet<FreeLancerViewModel> FreeLancers { get; set; }
        public DbSet<LeadContactViewModel> LeadContacts { get; set; }
        public DbSet<LeadViewModel> Leads { get; set; }
        public DbSet<MilestonesViewModel> Milestones { get; set; }
        public DbSet<OfferViewModel> Offers { get; set; }
        public DbSet<ProjectViewModel> Projects { get; set; }

        public FreelancerDataContext(DbContextOptions<FreelancerDataContext> options)
             : base(options)
        {
            Database.EnsureCreated();
        }
    }
  
}
