using NUnit.Framework;
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
    [TestFixture(Category = "Integration")]
    public class ValuesTests
    {
        [Test]
        public async Task HelloWorldAsync()
        {
            var client = ClientBuilder.BuildClient();
            var request = ClientBuilder.BuildRequest(
                "/api/values/5", HttpMethod.Get);

            var response = await client.SendAsync(request);

            Assert.IsNotNull(response.Content);
        }
    }
}
