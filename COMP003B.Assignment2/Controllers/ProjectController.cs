using Microsoft.AspNetCore.Mvc; 
namespace COMP003B.Assignment2.Controllers
{
    public class ProjectController : Controller
    {
        [HttpGet]
        public IActionResult Current()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Completed()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Ideas() {
            return View();
        }
    }
}
