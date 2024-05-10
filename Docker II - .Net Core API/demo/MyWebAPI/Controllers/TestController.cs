using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("test")]

    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello Scott Gerold from web API";
        }
    }
}
