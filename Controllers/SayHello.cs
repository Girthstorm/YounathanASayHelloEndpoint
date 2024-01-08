using Microsoft.AspNetCore.Mvc;

namespace YounathanASayHelloEndpoint.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class SayHello : ControllerBase
    {
        [HttpGet]
        [Route("sayHello/{name}")]
        public string sayHello(string name)
        {
            return "Hello, " + name;
        }
    }