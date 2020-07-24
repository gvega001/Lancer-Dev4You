using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lancer.Models;

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
    }
}
