using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lancer.Models;
using System.Data;
using System.Net;

namespace Lancer.Controllers
{


    public class HomeController : Controller
    {

        
      /*  private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        // GET: ContactController/Create
        [HttpGet, Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        // Post: ContactController/Create
        [HttpPost, Route("Contact")]
        public IActionResult Contact(LeadViewModel contact)
        {
            Console.WriteLine(contact);
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
            Console.WriteLine(Lancer);
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

            return View();
        } 
        [HttpGet, Route("Milestone")]
        public IActionResult Milestone()
        {
            return View();
        }
        [HttpPost, Route("Milestone")]
        public IActionResult Milestone(MilestonesViewModel milestones)
        {
            if (milestones is null)
            {
                throw new ArgumentNullException(nameof(milestones));
            }

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

            return View();
        }
    }
}
