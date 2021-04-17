using System.Net;
using NUnit.Framework;
using School.Testkit;

namespace School.Ping
{
    public class PingApiTest : ApiTest
    {
        [Test]
        public void ReturnsAlive()
        {
            var response = client.GetAsync("/ping").Result;
            
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Body<PingResponse>().Alive, Is.True);
        }
    }
}