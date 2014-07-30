using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AspNetViewsCodeReuseExamples.IdmbComponent
{
    public class MovieSearch
    {
        private readonly IIdmbAccess _idmbAccess;

        public MovieSearch(IIdmbAccess idmbAccess = null)
        {
            _idmbAccess = idmbAccess;
            if (idmbAccess == null)
                _idmbAccess = new IdmbAccess();
        }

        public List<Movie> SearchPopular(string query)
        {
            var queryResult = _idmbAccess.GetIdmbResult(query);
            var regex = new Regex("<.*?>");

            if (queryResult == null || queryResult.title_popular == null)
                return null;

            return queryResult.title_popular.Select(m => new Movie { Title = m.title, Description = regex.Replace(m.title_description, "")}).ToList();
        }
    }
}
