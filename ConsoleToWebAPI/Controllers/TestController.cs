using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController: ControllerBase
    {
        public string get()
        {
            return "hello";
        }
        public string get1()
        {
            return "string 1";
        }
    }
}
