using Microsoft.AspNetCore.Mvc;

namespace WebApplication2__.NET_core_.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Delete() { return View(); }
    }
}
