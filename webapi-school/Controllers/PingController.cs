using Microsoft.AspNetCore.Mvc;

namespace School.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public PingResponse Get()
        {
            return new() {Alive = true};
        }
    }

    public class PingResponse
    {
        public bool Alive { get; set; }
    }
}