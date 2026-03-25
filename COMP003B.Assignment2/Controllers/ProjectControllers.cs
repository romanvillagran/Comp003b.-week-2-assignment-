using Microsoft.AspNetCore.Mvc; 
namespace COMP003B.Assignment2.Controllers
{
    public class ProjectControllers : Controller
    {
        [HttpGet]
        public IActionResult current()
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
