using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace School
{
    public static class Application
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); })
                .Build()
                .Run();
        }
    }
}