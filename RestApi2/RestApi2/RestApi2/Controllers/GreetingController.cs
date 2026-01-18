using Microsoft.AspNetCore.Mvc;
using RestApi2.Model;

namespace RestApi2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase //controllerBase é proprio para API, devolve Json
    {   
        // para não precisar colocar o this.counter é usado o underline _
        private static long _counter = 0;
        private static readonly string _template = "Hello, {0}!";


        [HttpGet]
        public Greeting Get([FromQuery] string name = "World")
        {
            var id = Interlocked.Increment(ref _counter);
            var content = string.Format(_template, name);
            return new Greeting(1, content);
        }
    }
}
