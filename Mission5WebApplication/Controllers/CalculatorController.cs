using Microsoft.AspNetCore.Mvc;

namespace HobbyApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}