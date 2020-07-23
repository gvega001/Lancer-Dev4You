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
        [Route("Privacy")]
        public IActionResult Privacy()
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
        public IActionResult Contact([Bind("firstName", "latName", "email", "message")]ContactViewModel contact)
        {
            Debug.Write(contact.firstName);
            return View();
        }
    


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
