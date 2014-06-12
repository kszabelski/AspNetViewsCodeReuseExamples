using System;
using System.Web.Mvc;
using AspNetViewsCodeReuseExamples.Models;
using AspNetViewsCodeReuseExamples.ViewModels;

namespace AspNetViewsCodeReuseExamples.Controllers
{
    public class PartialViewsController : Controller
    {
        public ActionResult Index()
        {
            var model = new PartialViewsViewModel
            {
                IsSpecialUser = true,
                User = new User { Name = "Thomas", Surname = "Edison", Birthday = new DateTime(1847, 02, 11) }
            };

            return View(model);
        }

    }
}
