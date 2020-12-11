using eShop.Business.Services;
using eShop.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Domain;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace eShop.WebUI.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService;
        private string returnUrl;

        public UserController(IUserService userService)
        {
            this.userService = userService;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginModel loginModel)
        {
            Users users = userService.isValidUser(loginModel.UserName, loginModel.Password);

            if (users != null)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, users.UserName));
                claims.Add(new Claim(ClaimTypes.Role, users.Role));

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

                if (Url.IsLocalUrl(returnUrl))
                {
                    return LocalRedirect(returnUrl);
                }
            }


            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction(nameof(Index), "Home");
        }
    }
}
