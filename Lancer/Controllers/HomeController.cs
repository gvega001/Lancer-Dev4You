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

namespace Lancer.Controllers
{


    public class HomeController : Controller
    {

        
      private readonly ILogger<HomeController> _logger;
        private readonly FreelancerDataContext _db;
        public HomeController(ILogger<HomeController> logger, FreelancerDataContext db)
        {
            _logger = logger;
            _db = db;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet, Route("Contact")]

        public IActionResult Contact()
        {
          
            return View();
        }
        // Post: ContactController/Create
        [HttpPost, Route("Contact")]
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
        [HttpGet, Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet, Route("Services")]
        public IActionResult Services()
        {
            return View();
        }
        [HttpGet, Route("Resume")]
        public IActionResult Resume()
        {
            return View();
        }
       
        // GET: ContactController/Create
        [HttpGet, Route("Freelancer")]
        [Authorize]
        public IActionResult Freelancer()
        {
            return View();
        }
        // Post: ContactController/Create
        [HttpPost, Route("Freelancer")]
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
        [HttpGet, Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost, Route("Login")]
        public IActionResult Login(LoginViewModel login)
        {
            if (login is null)
            {
                throw new ArgumentNullException(nameof(login));
            }

            return View();
        }
        [HttpGet, Route("Register")]
        [Authorize]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost, Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (register is null)
            {
                throw new ArgumentNullException(nameof(register));
            }

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            _db.Users.Add(register);
            _db.SaveChanges();
            return View();
        } 
        [HttpGet, Route("Bid")]
        public IActionResult Bid()
        {
            return View();
        }
        [HttpPost, Route("Bid")]
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
        [HttpGet, Route("Business")]
        [Authorize]
        public IActionResult Business()
        {
            return View();
        }
        [HttpPost, Route("Business")]
        [Authorize]
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
        [HttpGet, Route("LeadContact")]
        [Authorize]
        public IActionResult LeadContact()
        {
            return View();
        }

        [HttpPost, Route("LeadContact")]
        [Authorize]
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
        [HttpGet, Route("Offer")]
        [Authorize]
        public IActionResult Offer()
        {
            return View();
        }
        [HttpPost, Route("Offer")]
        [Authorize]
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
        [HttpGet, Route("Milestone")]
        [Authorize]
        public IActionResult Milestone()
        {
            return View();
        }
        [HttpPost, Route("Milestone")]
        [Authorize]
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
        [HttpGet,Route("Project")]
        [Authorize]
        public IActionResult Project()
        {
            return View();
        }
        [HttpPost, Route("Project")]
        [ValidateAntiForgeryToken]
        [Authorize]
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
        [HttpPatch, Route("Project")]
        [ValidateAntiForgeryToken]
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
        public IActionResult FreelanceAdmin()
        {
            return View(_db.Projects.ToList());
        }
   
    }
}
