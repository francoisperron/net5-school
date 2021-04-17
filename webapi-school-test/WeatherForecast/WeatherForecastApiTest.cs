using System.Collections.Generic;
using System.Net;
using NUnit.Framework;
using School.Testkit;

namespace School.WeatherForecast
{
    public class WeatherForecastApiTest : ApiTest
    {
        [Test]
        public void ReturnsForecast()
        {
            var response = client.GetAsync("/forecast").Result;

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(response.Body<IEnumerable<WeatherForecastResponse>>(), Has.Count.EqualTo(5));
        }
    }
}