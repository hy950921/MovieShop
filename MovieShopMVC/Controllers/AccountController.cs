using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieShopMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICurrentUser _currentUser;

        public AccountController(IUserService userService, ICurrentUser currentUser)
        {
            _userService = userService;
            _currentUser = currentUser;
        }

        // method for registration

        // show the empty view that wil have all the text boxes and submit button
        // localhost/account/register

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterRequestModel model)
        {


            if (!ModelState.IsValid)
            {
                return View();
            }

            // save to DB

            await _userService.RegisterUser(model);
            // redirect to Login

            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = await _userService.Login(model.Email, model.Password);

            if (user == null)
            {
                // wrong password
                ModelState.AddModelError(string.Empty, "Invalid password");
                return View();
            }


            // create cookie claims
            var claims = new List<Claim>
            {
                 new Claim(ClaimTypes.Email, user.Email),
                 new Claim(ClaimTypes.GivenName, user.FirstName),
                 new Claim(ClaimTypes.Surname, user.LastName),
                 new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            // identity object
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);


            // HttpContext
            // URL, Http method type, form body, browser, Ip address, 


            // create the cookie
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return LocalRedirect("~/");



            // correct pasword
            // display, FirstName, LastName, Email
            // Button/Link Logout
            // Cookie Based Authentication....
            return View();
        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Profile()
        {
            var userId = _currentUser.UserId;
            var userProfileResponse = _userService.GetUserDetails(userId).GetAwaiter().GetResult();
            return View(userProfileResponse);
        }
    }
}