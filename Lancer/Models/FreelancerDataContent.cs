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
    }
}
