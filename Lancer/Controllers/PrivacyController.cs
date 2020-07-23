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
    public class PrivactyController : Controller
    {
        [Route("Home/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }



    }
}
