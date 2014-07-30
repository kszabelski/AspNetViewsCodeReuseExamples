using System.Web.Mvc;

namespace AspNetViewsCodeReuseExamples.Controllers
{
    public class LayoutsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Nested()
        {
            return View();
        }
    }
}
