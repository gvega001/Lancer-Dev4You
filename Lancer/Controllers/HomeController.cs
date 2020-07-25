using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lancer.Models;
using System.Data;
using System.Net;
using System.Linq;

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

        // GET: ContactController/
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
        public IActionResult Freelancer()
        {
            return View();
        }
        // Post: ContactController/Create
        [HttpPost, Route("Freelancer")]
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
                return View();
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
                return View();
            }
            _db.Bids.Add(bid);
            _db.SaveChanges();
            return View();
        }
        [HttpGet, Route("Business")]
        public IActionResult Business()
        {
            return View();
        }
        [HttpPost, Route("Business")]
        public IActionResult Business(BusinessAccountViewModel business)
        {
            if (business is null)
            {
                throw new ArgumentNullException(nameof(business));
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.BusinessAcounts.Add(business);
            _db.SaveChanges();
            return View();
        } 
        [HttpGet, Route("LeadContact")]
        public IActionResult LeadContact()
        {
            return View();
        }

        [HttpPost, Route("LeadContact")]
        public IActionResult LeadContact(LeadContactViewModel leadContact)
        {
            if (leadContact is null)
            {
                throw new ArgumentNullException(nameof(leadContact));
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.LeadContacts.Add(leadContact);
            _db.SaveChanges();
            return View();
        }
        [HttpGet, Route("Offer")]
        public IActionResult Offer()
        {
            return View();
        }
        [HttpPost, Route("Offer")]
        public IActionResult Offer(OfferViewModel offer)
        {
            if (offer is null)
            {
                throw new ArgumentNullException(nameof(offer));
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.Offers.Add(offer);
            _db.SaveChanges();
            return View();
        } 
        [HttpGet, Route("Milestone")]
        public IActionResult Milestone()
        {
            return View();
        }
        [HttpPost, Route("Milestone")]
        public IActionResult Milestone(MilestonesViewModel milestone)
        {
            if (milestone is null)
            {
                throw new ArgumentNullException(nameof(milestone));
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.Milestones.Add(milestone);
            _db.SaveChanges();
            return View();
        } 
        [HttpGet, Route("Project")]
        public IActionResult Project()
        {
            return View();
        }
        [HttpPost, Route("Project")]
        public IActionResult Project(ProjectViewModel project)
        {
            if (project is null)
            {
                throw new ArgumentNullException(nameof(project));
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            _db.Projects.Add(project);
            _db.SaveChanges();
            return View();
        }
    }
}
