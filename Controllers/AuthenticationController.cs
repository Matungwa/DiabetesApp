using Microsoft.AspNetCore.Mvc;

namespace DiabetesApp.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
