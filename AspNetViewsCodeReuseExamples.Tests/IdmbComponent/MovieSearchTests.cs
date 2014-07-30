using System.Collections.Generic;
using System.Linq;
using AspNetViewsCodeReuseExamples.IdmbComponent;
using Moq;
using NUnit.Framework;

namespace AspNetViewsCodeReuseExamples.Tests.IdmbComponent
{
    public class MovieSearchTests
    {
        [Test]
        public void SearchPopularShouldClearDescriptionFromHtmlTags()
        {
            var fakeIdbmAccess = new Mock<IIdmbAccess>();
            fakeIdbmAccess.Setup(m => m.GetIdmbResult("test"))
                .Returns(new IdmbResult
                {
                    title_popular =
                        new List<TitlePopular>
                        {
                            new TitlePopular {title_description = "2004, <a href='/name/nm0685759/'>Pitof</a>"}
                        }
                });

            var search = new MovieSearch(fakeIdbmAccess.Object);

            Assert.AreEqual("2004, Pitof", search.SearchPopular("test").First().Description);
        }
    }
}
