using System.Linq;
using AspNetViewsCodeReuseExamples.IdmbComponent;
using NUnit.Framework;

namespace AspNetViewsCodeReuseExamples.Tests.IdmbComponent
{
    public class IdmbAccessTests
    {
        [Test]
        public void ShouldGetIdmbResultWithoutError()
        {
            var result = GetIdmbResults();
            Assert.IsNotNull(result);
        }

        [Test]
        public void ShouldGetNotEmptyListForPopularTitle()
        {
            var result = GetIdmbResults();
            Assert.Greater(result.title_popular.Count(), 0);
        }

        [Test]
        public void ShouldGetPopularMoviesWithNotEmptyData()
        {
            var result = GetIdmbResults();
            Assert.IsNotEmpty(result.title_popular.First().title);
            Assert.IsNotEmpty(result.title_popular.First().title_description);
        }

        private IdmbResult GetIdmbResults()
        {
            var search = new IdmbAccess();
            return search.GetIdmbResult("batman");
        }
    }
}
