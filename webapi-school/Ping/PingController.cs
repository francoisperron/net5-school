using Microsoft.AspNetCore.Mvc;

namespace School.Ping
{
    [ApiController]
    [Route("ping")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public PingResponse Get()
        {
            return new() {Alive = true};
        }
    }
}