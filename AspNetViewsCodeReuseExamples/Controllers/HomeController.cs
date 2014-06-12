using System.Web.Mvc;

namespace AspNetViewsCodeReuseExamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
