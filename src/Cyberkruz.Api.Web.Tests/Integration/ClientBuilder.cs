using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Cyberkruz.Api.Web.Tests.Integration
{
    public class ClientBuilder
    {
        public static HttpServer BuildServer()
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            var server = new HttpServer(config);
            return server;
        }

        public static HttpRequestMessage BuildRequest(string location, HttpMethod method)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost" + location)
            };
            request.Headers.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return request;
        }

        public static HttpClient BuildClient()
        {
            var server = BuildServer();
            var client = new HttpClient(server);
            return client;
        }
    }
}
