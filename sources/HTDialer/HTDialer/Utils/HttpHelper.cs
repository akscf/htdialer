using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/**
 * 
 * @author AlexandrinK <aks@cforge.org>
 */
namespace HTDialer.Utils
{
    class HttpHelper
    {

        public static async Task<string> HttpGetAsync(string url)
        {
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)await req.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public static string HttpGet(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)req.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

    }
}
