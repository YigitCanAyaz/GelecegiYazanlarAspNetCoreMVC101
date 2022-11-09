using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Asp.net Core";

            // ViewBag.Names = new List<string> { "ahmet", "mehmet", "hasan" };

            ViewData["age"] = 30;

            ViewData["names"] = new List<string>() { "ahmet", "mehmet", "hasan" };

            ViewBag.Person = new { Id = 1, Name = "Ahmet", Age = 23 };

            return View();
        }

        public IActionResult Index2()
        {
            // return View();

            // Action, Controller
            return RedirectToAction("Index", "Example");
        }

        public IActionResult Yca()
        {
            TempData["surname"] = "Yildiz";

            return View();
        }

        public IActionResult Yca2()
        {

            // var surname = TempData["surname"]; we can even do that

            return View();
        }

        public IActionResult ParameterView(int id)
        {
            // Sending data with RedirectToAction
            return RedirectToAction("JsonResultParameter", "Example", new { id = id });
        }

        public IActionResult JsonResultParameter(int id)
        {
            return Json(new { Id = id });
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
