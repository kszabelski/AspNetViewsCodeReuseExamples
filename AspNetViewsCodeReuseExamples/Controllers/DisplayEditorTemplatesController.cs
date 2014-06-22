using System;
using System.Web.Mvc;
using AspNetViewsCodeReuseExamples.Models;
using AspNetViewsCodeReuseExamples.ViewModels;
using IdmbAccess;

namespace AspNetViewsCodeReuseExamples.Controllers
{
    public class DisplayEditorTemplatesController : Controller
    {
        private const string DisplayEditorTemplatesViewModelSessionKey = "DisplayEditorTemplatesViewModel";
        
        public ActionResult Index()
        {
            return RedirectToAction("DisplayTemplates");
        }

        public ActionResult DisplayTemplates()
        {
            var model = GetOrCreateDefaultDisplayEditorTemplatesViewModel();

            return View(model);
        }

        [HttpGet]
        public ActionResult EditorTemplates()
        {
            var model = GetOrCreateDefaultDisplayEditorTemplatesViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult EditorTemplates(DisplayEditorTemplatesViewModel model)
        {
            Session[DisplayEditorTemplatesViewModelSessionKey] = model;
            return RedirectToAction("DisplayTemplates");
        }

        private DisplayEditorTemplatesViewModel GetOrCreateDefaultDisplayEditorTemplatesViewModel()
        {
            var model = Session[DisplayEditorTemplatesViewModelSessionKey] as DisplayEditorTemplatesViewModel;

            if (model == null)
            {
                model = new DisplayEditorTemplatesViewModel
                {
                    AreYouOk = false,
                    User = new User { Name = "John", Surname = "Schmidt", Birthday = new DateTime(1975, 03, 08) },
                    Movie = new Movie { Title = "The Fast and the Furious", Description = "Los Angeles police officer Brian O'Connor must decide where his loyalties really lie when he becomes enamored with the street racing world he has been sent undercover to destroy." },
                    SpecialMovie = new Movie { Title = "Special", Description = "A lonely metermaid has a psychotic reaction to his medication and becomes convinced he's a superhero. A very select group of people in life are truly gifted. Special is a movie about everyone else."}
                };

                Session[DisplayEditorTemplatesViewModelSessionKey] = model;
            }

            return model;
        }
    }
}
