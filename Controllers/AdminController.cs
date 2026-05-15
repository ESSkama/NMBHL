using Microsoft.AspNetCore.Mvc;

namespace NMBHDL.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Conditions()
        {
            return View();
        }

        public IActionResult Allergies()
        {
            return View();
        }

        public IActionResult Medication()
        {
            return View();
        }
    }
}
