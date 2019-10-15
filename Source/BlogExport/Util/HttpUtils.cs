using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlogExport.Util
{
    public class HttpUtils
    {
        public static CookieContainer GetCookieContainter(string url)
        {
            return GetCookieContainter(url, "",false,"");
        }
        public static CookieContainer GetCookieContainter(string url,string referer,bool keepAlive,string host)
        {
            var cookieContainter = new CookieContainer();
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            req.CookieContainer = cookieContainter;
            req.Method = "POST";
            req.KeepAlive = keepAlive;
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.90 Safari/537.36";
            if (!string.IsNullOrEmpty(referer))
                req.Referer = referer;
            if(!string.IsNullOrEmpty(host))
                req.Host = host;
            req.Accept = "application/json, text/plain, */*";
            req.ContentType = "application/json;charset=utf-8";
            var resp = (HttpWebResponse)req.GetResponse();
            return cookieContainter;
        }

        public static string PostDataAndGetData(string url,string data,string refer,string host,bool keepAlive,CookieContainer cc=null)
        {
            var cookieContainter = (cc == null ? new CookieContainer() : cc);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            req.CookieContainer = cookieContainter;
            req.Method = "POST";
            req.KeepAlive = keepAlive;
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.90 Safari/537.36";
            req.Accept = "application/json, text/plain, */*";
            req.ContentType = "application/json;charset=utf-8";
            req.Referer = refer;
            req.Host = host;

            byte[] bytes = Encoding.UTF8.GetBytes(data);
            req.ContentLength = bytes.Length;
            Stream stream = req.GetRequestStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Close();

            var resp = (HttpWebResponse)req.GetResponse();
            Stream s = resp.GetResponseStream();
            StreamReader reader = new StreamReader(s, Encoding.UTF8);
            string value = reader.ReadToEnd();

            return value;
        }
    }
}
