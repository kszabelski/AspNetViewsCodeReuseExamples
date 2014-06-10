using System.Collections;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AspNetViewsCodeReuseExamples.Helpers
{
    public static class HtmlHelpers
    {
        public static IHtmlString UnorderedList(this HtmlHelper html, IEnumerable list)
        {
            var builder = new StringBuilder("<ul>");
            foreach (var item in list)
                builder.Append(string.Format("<li>{0}</li>", item));
            builder.Append("</ul>");

            return new HtmlString(builder.ToString());
        }
    }
}