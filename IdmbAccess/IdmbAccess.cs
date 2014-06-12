using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace IdmbAccess
{
    public class IdmbAccess : IIdmbAccess
    {
        public IdmbResult GetIdmbResult(string query)
        {
            var response = GetResponse(query);
            return DeserializeJson(response);
        }

        private static string GetResponse(string query)
        {
            var baseAddress = "http://www.imdb.com/xml/find?json=1&nr=1&tt=on&q=";
            var wb = new WebClient();
            wb.Encoding = Encoding.UTF8;
            return wb.DownloadString(baseAddress + query);
        }

        private static dynamic DeserializeJson(string result)
        {
            return new JavaScriptSerializer().Deserialize<IdmbResult>(result);
        }
    }
}