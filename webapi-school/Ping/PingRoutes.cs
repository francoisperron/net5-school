using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace School.Ping
{
    public static class PingRoutes
    {
        public static void UseEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/ping", async context => { await context.Response.WriteAsJsonAsync(new PingEndpoint().Get()); });
        }
    }
}