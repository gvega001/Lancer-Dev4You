using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lancer.Models;
using System.Data;
using System.Net;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;

namespace Lancer.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
     

        private readonly FreelancerDataContext _db;
        public AccountController( FreelancerDataContext db)
        {
            
            _db = db;

        }
        // Post: ContactController/Create

        [HttpPost, Route("Contact")]
        [AllowAnonymous]
        public IActionResult Contact(LeadViewModel contact)
        {
            if (contact is null)
            {
                throw new ArgumentNullException(nameof(contact));
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.Leads.Add(contact);
            _db.SaveChanges();
            return View();
        }
       
        [Authorize(Policy = "RequireAdministratorRole")]
        // GET: ContactController/Create
        [HttpGet, Route("/Account/Freelancer")]
        [Authorize]
        public IActionResult Freelancer()
        {
            return View();
        }
        // Post: ContactController/Create
        [Authorize(Policy = "RequireAdministratorRole")]
        [HttpPost, Route("/Account/Freelancer")]
        [Authorize]
        public IActionResult Freelancer(FreeLancerViewModel Lancer)
        {
            if (Lancer is null)
            {
                throw new ArgumentNullException(nameof(Lancer));
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.FreeLancers.Add(Lancer);
            _db.SaveChanges();
            return View();
        }
        [HttpGet, Route("/Account/Bid")]
        [Authorize]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Bid()
        {
            return View();
        }
        [HttpPost, Route("/Account/Bid")]
        [Authorize]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Bid(BidViewModel bid)
        {
            if (bid is null)
            {
                throw new ArgumentNullException(nameof(bid));
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction("FreelanceAdmin");
            }
            _db.Bids.Add(bid);
            _db.SaveChanges();
            return View();
        }
        [HttpGet, Route("/Account/Business")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Business()
        {
            return View();
        }
        [HttpPost, Route("/Account/Business")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Business(BusinessAccountViewModel business)
        {
            if (business is null)
            {
                throw new ArgumentNullException(nameof(business));
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction("FreelanceAdmin");
            }
            _db.BusinessAcounts.Add(business);
            _db.SaveChanges();
            return View();
        }

        [HttpGet, Route("/Account/LeadContact")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult LeadContact()
        {
            return View();
        }

        [HttpPost, Route("/Account/LeadContact")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult LeadContact(LeadContactViewModel leadContact)
        {
            if (leadContact is null)
            {
                throw new ArgumentNullException(nameof(leadContact));
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction("FreelanceAdmin");
            }
            _db.LeadContacts.Add(leadContact);
            _db.SaveChanges();
            return View();
        }
        [HttpGet, Route("/Account/Offer")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Offer()
        {
            return View();
        }
        [HttpPost, Route("/Account/Offer")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Offer(OfferViewModel offer)
        {
            if (offer is null)
            {
                throw new ArgumentNullException(nameof(offer));
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction("FreelanceAdmin");
            }
            _db.Offers.Add(offer);
            _db.SaveChanges();
            return View();
        }
        [HttpGet, Route("/Account/Milestone")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Milestone()
        {
            return View();
        }
        [HttpPost, Route("/Account/Milestone")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Milestone(MilestonesViewModel milestone)
        {
            if (milestone is null)
            {
                throw new ArgumentNullException(nameof(milestone));
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction("FreelanceAdmin");
            }
            _db.Milestones.Add(milestone);
            _db.SaveChanges();
            return View();
        }
        [HttpGet, Route("/Account/Project")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Project()
        {
            return View();
        }
        [HttpPost, Route("/Account/Project")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Project(ProjectViewModel project)
        {
            if (project is null)
            {
                throw new ArgumentNullException(nameof(project));
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Project");
            }
            _db.Projects.Add(project);
            _db.SaveChanges();
            return View();
        }
        [HttpPatch, Route("/Account/Project")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> Project(long id, [Bind("ID,Amount,DaysToDelivery,Description,Summary")] ProjectViewModel project)
        {
            if (id != project.Id)
            {
                throw new ArgumentNullException(nameof(project));
            }
            if (!ModelState.IsValid)
            {
                try
                {
                    _db.Update(project);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("FreelanceAdmin");
            }
            _db.Projects.Add(project);
            _db.SaveChanges();
            return View();
        }

        private bool ProjectExists(ProjectViewModel project)
        {
            throw new NotImplementedException();
        }



        [HttpGet, Route("FreelanceAdmin")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult FreelanceAdmin()
        {
            return View(_db.Projects.ToList());
        }


    
}
}
