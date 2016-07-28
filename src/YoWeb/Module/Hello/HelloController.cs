using Microsoft.AspNetCore.Mvc;

namespace YoWeb.Module.Hello
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        private readonly IHelloWorld HelloWorld;

        public HelloController(IHelloWorld helloWorld)
        {
            HelloWorld = helloWorld;
        }

        [HttpGet("{name}", Name = "SayHi")]
        public IActionResult SayHi(string name)
        {
            return new ObjectResult(HelloWorld.Say(name));
        }
    }
}