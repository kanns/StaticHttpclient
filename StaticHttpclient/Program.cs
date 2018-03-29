using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace StaticHttpclient
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static  Program()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        static void Main(string[] args)
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, "yourappname/yourmethod");
            
            string body = "the body of your message";
            req.Content = new StringContent(body, Encoding.UTF8);
            Task<HttpResponseMessage> httpRequest = client.SendAsync(req, HttpCompletionOption.ResponseContentRead);
        }
    }
}