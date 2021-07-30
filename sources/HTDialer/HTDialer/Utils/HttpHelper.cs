using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/**
 * 
 * Copyright (C) AlexandrinKS
 * https://akscf.me/
 */
namespace HTDialer.Utils
{
    class HttpHelper
    {

        public static async Task<string> HttpGetAsync(string credentials, string url)
        {
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(url);
            if (!String.IsNullOrEmpty(credentials))
            {
                string cre = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(credentials));
                req.Headers.Add("Authorization", "Basic " + cre);
            }
            using (HttpWebResponse response = (HttpWebResponse)await req.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return await reader.ReadToEndAsync();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="credentials">username:password</param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string HttpGet(string credentials, string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            if (!String.IsNullOrEmpty(credentials))
            {
                string cre = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(credentials));
                req.Headers.Add("Authorization", "Basic " + cre);
            }
            //
            using (HttpWebResponse response = (HttpWebResponse)req.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

    }
}
