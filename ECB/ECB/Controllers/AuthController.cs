using Microsoft.AspNetCore.Mvc;

namespace ECB.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult AddDish()
        {
            return View();
        }
        public IActionResult AddRecipe()
        {
            return View();
        }
    }
}
