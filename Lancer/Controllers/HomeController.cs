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

    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<HomeController> _logger;
     
        public HomeController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ILogger<HomeController> logger)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
         
        }
        [AllowAnonymous]
        [HttpGet, Route("Login")]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }
        [AllowAnonymous]
        [HttpPost, Route("Login")]
        public async Task<IActionResult> Login(LoginViewModel login, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(
                login.EmailAddress, login.Password,
                login.RememberMe, false
            );

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Login error!");
                return View();
            }

            if (string.IsNullOrWhiteSpace(returnUrl))
                return RedirectToAction("Index", "Home");

            return Redirect(returnUrl);
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();

            if (string.IsNullOrWhiteSpace(returnUrl))
                return RedirectToAction("Index", "Home");

            return Redirect(returnUrl);
        }
        [AllowAnonymous]
        [HttpGet, Route("Register")]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }
        [AllowAnonymous]
        [HttpPost, Route("Register")]
        public async Task<IActionResult> Register(RegisterViewModel registration)
        {
            if (!ModelState.IsValid)
                return View(registration);

            IdentityUser newUser = new IdentityUser
            {
                Email = registration.EmailAddress,
                UserName = registration.EmailAddress,
            };

            var result = await _userManager.CreateAsync(newUser, registration.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors.Select(x => x.Description))
                {
                    ModelState.AddModelError("", error);
                }

                return View();
            }

            return RedirectToAction("Login");
        }

        [Route("")]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet, Route("Contact")]
        [AllowAnonymous]
        public IActionResult Contact()
        {

            return View();
        }
      

        [HttpGet, Route("Services")]
        public IActionResult Services()
        {
            return View();
        }
        [HttpGet, Route("Resume")]
        [AllowAnonymous]
        public IActionResult Resume()
        {
            return View();
        }


        [HttpGet, Route("Privacy")]
        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }


    }
}

