using System.Collections.Generic;
using System.Web.Mvc;
using AspNetViewsCodeReuseExamples.ViewModels;
using IdmbAccess;

namespace AspNetViewsCodeReuseExamples.Controllers
{
    public class ChildActionController : Controller
    {
        public ActionResult Index(string query = null)
        {
            return View(new ChildActionViewModel { Query = query });
        }
        
        [ChildActionOnly]
        public ActionResult SearchMovies(string query)
        {
            List<Movie> movies = null;
            if (!string.IsNullOrWhiteSpace(query))
            {
                try
                {
                    movies = new MovieSearch().SearchPopular(query);
                }
                catch
                {
                    // For purposes of this sample app just assume there is no results :D
                }
            }

            // Return PartialView instead of View to ignore default view layout.
            return PartialView(new SearchMovieResultsViewModel(query, movies));
        }
    }
}
