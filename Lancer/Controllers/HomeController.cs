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

        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
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
            return View();
        }
        [HttpGet, Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost, Route("Register")]
        public IActionResult Register(LoginViewModel login)
        {
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
            return View();
        }
    }
}
