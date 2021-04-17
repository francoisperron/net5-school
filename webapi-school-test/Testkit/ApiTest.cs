using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;

namespace School.Testkit
{
    public abstract class ApiTest
    {
        protected HttpClient client;

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
    }
}