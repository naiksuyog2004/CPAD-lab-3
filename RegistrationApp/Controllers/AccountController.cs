using Microsoft.AspNetCore.Mvc;
using RegistrationApp.Models;

namespace RegistrationApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // TODO: Implement user registration logic here (save to DB, etc.)

                ViewBag.SuccessMessage = "Registration successful!";
                ModelState.Clear();
                return View();
            }
            return View(model);
        }
    }
}
