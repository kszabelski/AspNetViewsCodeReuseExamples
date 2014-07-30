using System.Collections.Generic;
using System.Web.Mvc;
using AspNetViewsCodeReuseExamples.ViewModels;

namespace AspNetViewsCodeReuseExamples.Controllers
{
    public class HtmlHelperController : Controller
    {
        public ActionResult Index()
        {
            var model = new HtmlHelperViewModel
            {
                Planets = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" }
            };

            return View(model);
        }

    }
}
