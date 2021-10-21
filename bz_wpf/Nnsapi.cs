using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace bz_wpf
{
    class Nnsapi
    {
        public static JsonBase HttpR() {
            string url = "http://47.100.8.63:8080/nns/listnews";
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentLength = 0L;
            request.ContentType = "text/xml";
            Stream reqstream = request.GetRequestStream();
  
            //声明一个HttpWebRequest请求
            request.Timeout = 90000;
            //设置连接超时时间
            request.Headers.Set("Pragma", "no-cache");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream streamReceive = response.GetResponseStream();
            Encoding encoding = Encoding.UTF8;

            StreamReader streamReader = new StreamReader(streamReceive, encoding);
            string json = streamReader.ReadToEnd();
            streamReceive.Dispose();
            streamReader.Dispose();
            JsonBase jb = JsonConvert.DeserializeObject<JsonBase>(json);
            return jb;
        }
    }
}
