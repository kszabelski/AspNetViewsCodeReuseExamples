using System.Collections.Generic;
using IdmbAccess;

namespace AspNetViewsCodeReuseExamples.ViewModels
{
    public class SearchMovieResultsViewModel
    {
        public SearchMovieResultsViewModel(string query, List<Movie> movies)
        {
            Query = query;
            Movies = movies;
        }

        public string Query { get; private set; }
        public List<Movie> Movies { get; private set; }
    }
}