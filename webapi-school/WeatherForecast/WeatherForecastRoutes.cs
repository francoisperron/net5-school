using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace School.WeatherForecast
{
    public static class WeatherForecastRoutes
    {
        public static void UseEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/forecast", async context => { await context.Response.WriteAsJsonAsync(new WeatherForecastEndpoint().Get()); });
        }
    }
}