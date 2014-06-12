using System;
using System.Web.Mvc;
using AspNetViewsCodeReuseExamples.Models;
using AspNetViewsCodeReuseExamples.ViewModels;

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
                    User = new User() { Name = "John", Surname = "Schmidt", Birthday = new DateTime(1975, 03, 08) }
                };

                Session[DisplayEditorTemplatesViewModelSessionKey] = model;
            }

            return model;
        }
    }
}
