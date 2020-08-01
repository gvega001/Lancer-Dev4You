using Lancer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lancer;
using System;
using System.Linq;


namespace Lancer.Models
{

    public static class SeedData
    {
       
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FreelancerDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FreelancerDataContext>>()))
            {
                // Look for any Business Accounts.
                if (context.BusinessAcounts.Any())
                {
                    return;   // DB has been seeded
                }



                context.BusinessAcounts.AddRange(
                    new BusinessAccountViewModel
                    {
                        Id = 1001,
                        BusinessName = "1st Light Energy",
                        Address = "1869 Moffat Blvd",
                        City = "Manteca",
                        State = "CA",
                        ZipCode = "92551",
                        Email = "info@1stle.com"

                    }
                      );
                context.SaveChanges();
                // Look for any Bids.
                if (context.Bids.Any())
                {
                    return;   // DB has been seeded
                }
           
            }
        }
    }

}