using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace _25_MVC_Intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var student = new JsonResult(new { id = 1, name = "Ali", surname = "Quliyev" });

            //return student;

            return View("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id is null || id < 1)
            {
                return RedirectToAction(nameof(Error));
            }
            return RedirectToAction(nameof(Index), "Product");
        }

        public ViewResult Error()
        { 
            return View();
        }
    }
}
