using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;

namespace School.Ping
{
    public class PingApiTest
    {
        private HttpClient client;

        [SetUp]
        public async Task Setup()
        {
            var hostBuilder = new HostBuilder().ConfigureWebHost(webHost =>
                {
                    webHost.UseTestServer();
                    webHost.UseStartup<Startup>();
                });
            var host = await hostBuilder.StartAsync();
            client = host.GetTestClient();
        }

        [Test]
        public void ReturnsAlive()
        {
            var response = client.GetAsync("http://localhost:5001/ping").Result;
            
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Body<PingResponse>().Alive, Is.True);
        }
    }
}