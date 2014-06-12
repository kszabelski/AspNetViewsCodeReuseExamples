using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AspNetViewsCodeReuseExamples.Models;
using AspNetViewsCodeReuseExamples.ViewModels;

namespace AspNetViewsCodeReuseExamples.Controllers
{
    public class RazorHelpersController : Controller
    {
        public ActionResult Index()
        {
            var model = new RazorHelpersViewModel
            {
                Users = new List<User> {
                    new User { Name = "Barbara", Birthday = new DateTime(2001, 04, 28) },
                    new User { Name = "Thomas", Surname = "Edison", Birthday = new DateTime(1847, 02, 11) },
                    new User { Birthday = new DateTime(1987, 05, 25) }
                }
            };

            return View(model);
        }

    }
}
