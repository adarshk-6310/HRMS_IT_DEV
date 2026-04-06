using HRMS_IT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HRMS_IT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        // Controllers/AccountController.cs
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Try to find user by email or username
            //var user = await _userManager.FindByEmailAsync(model.UserNameOrEmail)
            //        ?? await _userManager.FindByNameAsync(model.UserNameOrEmail);

            //if (user == null)
            //{
            //    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            //    return View(model);
            //}

            // Now sign in using the found user's UserName
            //var result = await _signInManager.PasswordSignInAsync(
            //    user.UserName!,          // We MUST use UserName here
            //    model.Password,
            //    model.RememberMe,
            //    lockoutOnFailure: false);

            //if (result.Succeeded)
            //{
            //    return LocalRedirect(GetRedirectUrl(returnUrl));
            //}

            //if (result.IsLockedOut)
            //{
            //    return RedirectToAction(nameof(Lockout));
            //}

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(model);
        }


    }
}
