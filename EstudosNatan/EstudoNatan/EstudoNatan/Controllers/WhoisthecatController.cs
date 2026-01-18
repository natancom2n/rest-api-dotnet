using EstudoNatan.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace EstudoNatan.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WhoisthecatController : ControllerBase
    {
        private static long _contador = 0;
        private static readonly string _template = "Quem é o Gatão? {0}, com salario de {1}, {2}";
       
        [HttpGet]
        public Whoisthecat Get([FromQuery] string name = "Gatão?", double salario = 9000f )
        {
                var id = Interlocked.Increment(ref _contador);
                var resultado = "Deu Errado";

            if (salario > 8000)
                {
                resultado = " esse é foda!";
            }
            else { resultado = " esse é mais ou menos"; }

            var content = string.Format(_template, name, salario, resultado);

            return new Whoisthecat(1, content);
        }
    }
}
