using Lancer.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lancer.Models
{

    public class FreelancerDataContext : DbContext 
    { 
        public FreelancerDataContext() : base("FreelancerDataContext")
    {

    }
  
        public Microsoft.EntityFrameworkCore.DbSet<BidViewModel> Bids { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<BusinessAccountViewModel> BusinessAcounts { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<FreeLancerViewModel> FreeLancers { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<LeadContactViewModel> LeadContacts { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<LeadViewModel> Leads { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<MilestonesViewModel> Milestones { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<OfferViewModel> Offers { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ProjectViewModel> Projects { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<RegisterViewModel> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
