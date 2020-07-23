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

    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }


        // GET: ContactController/Create
        [HttpGet,Route("/Home/Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        // Post: ContactController/Create
        [HttpPost,Route("/Home/Contact")]
        public IActionResult Contact([Bind("firstName", "latName", "email", "message")] ContactViewModel contact)
        {
            Debug.Write(contact.firstName);
            return View();
        }


    }
}
