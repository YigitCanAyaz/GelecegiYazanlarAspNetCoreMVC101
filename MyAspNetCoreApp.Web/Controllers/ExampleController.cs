using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
           // return View();

            // Action, Controller
            return RedirectToAction("Index", "Example");
        }

        public IActionResult ContentResult()
        {
            return Content("ContentResult");
        }

        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, name = "pencil 1", price = 100 });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }


    }
}
