using Microsoft.AspNetCore.Mvc;

namespace NMBHDL.Controllers
{
    public class TechnicianController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReceiveSamples()
        {
            return View();
        }

        public IActionResult ProcessTests()
        {
            return View();
        }

        public IActionResult CaptureResults()
        {
            return View();
        }

        public IActionResult VerifyResults()
        {
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }
    }
}
