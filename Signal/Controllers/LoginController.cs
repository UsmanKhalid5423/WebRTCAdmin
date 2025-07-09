using Microsoft.AspNetCore.Mvc;
using Signal.Models;
using Microsoft.Extensions.Configuration;


namespace Signal.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration; // Injecting IConfiguration
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            string storedUsername = _configuration["LoginCredentials:Username"];
            string storedPassword = _configuration["LoginCredentials:Password"];
            if (ModelState.IsValid)
            {
                if (model.Username == storedUsername && model.Password == storedPassword) // Simple example
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["ErrorMessage"] = "Invalid username or password.";
                }
            }
            return View("Index", model);
        }

    }
}
