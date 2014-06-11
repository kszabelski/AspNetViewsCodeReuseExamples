using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetViewsCodeReuseExamples.Models;
using AspNetViewsCodeReuseExamples.ViewModels;

namespace AspNetViewsCodeReuseExamples.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HtmlHelper()
        {
            var model = new HtmlHelperViewModel
            {
                Planets = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" }
            };

            return View(model);
        }

        public ActionResult DisplayTemplates()
        {
            var model = new DisplayEditorTemplatesViewModel
            {
                AreYouOk = false,
                User = new User()
                {
                    Name = "John",
                    Surname = "Schmidt",
                    Birthday = new DateTime(1975, 03, 08)
                }
            };

            return View(model);
        }
    }
}
