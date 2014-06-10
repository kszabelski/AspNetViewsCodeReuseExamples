using System.Web;

namespace AspNetViewsCodeReuseExamples.Helpers
{
    public static class CopyrightsHelper
    {
        public static IHtmlString Copyrights(string dates, string author)
        {
            return new HtmlString(string.Format("<div>Copyright {0} {1} , All Rights Reserved.</div>", dates, author));
        }
    }
}