using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace IdmbAccess.Tests
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
