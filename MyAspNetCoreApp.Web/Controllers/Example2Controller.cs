using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class Example2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexNoLayout()
        {
            return View();
        }
    }
}
