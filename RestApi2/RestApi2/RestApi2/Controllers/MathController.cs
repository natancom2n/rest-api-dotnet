using Microsoft.AspNetCore.Mvc;
using RestApi2.Services;
using RestApi2.Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RestApi2.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase //controller retorna views, para matemática usar ControllerBase
    {

        private readonly MathService _service;

        public MathController(MathService service)
        {
            _service = service;
        }


        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sum = _service.Sum (
                    NumberHelper.ConvertToDecimal(firstNumber), 
                    NumberHelper.ConvertToDecimal(secondNumber)
                    );
                return Ok(sum);
            }
                return BadRequest("Invalid input!");
        }


        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {

            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sub = _service.Sub (
                    NumberHelper.ConvertToDecimal(firstNumber), 
                    NumberHelper.ConvertToDecimal(secondNumber)
                    );
                return Ok(sub);
            }
            return BadRequest("Invalid input!");

        }

        [HttpGet("mul/{firstNumber}/{secondNumber}")]
        public IActionResult mul(string firstNumber, string secondNumber)
        {

            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var mul = _service.Mul(
                    NumberHelper.ConvertToDecimal(firstNumber), 
                    NumberHelper.ConvertToDecimal(secondNumber)
                    );
                return Ok(mul);
            }
            return BadRequest("Invalid input!");
        }

        [HttpGet("med/{firstNumber}/{secondNumber}")]
        public IActionResult med(string firstNumber, string secondNumber)
        {

            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var med = _service.Med(
                    NumberHelper.ConvertToDecimal(firstNumber),
                    NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(med);
            }
            return BadRequest("Invalid input!");
        }

        [HttpGet("square/{number}")]
        public IActionResult square(string number)
        {
            if (NumberHelper.IsNumeric(number))
            {
                var square = _service.Square(NumberHelper.ConvertToDecimal(number));
               
                return Ok(square);
            }
            return BadRequest("Invalid input!");
        }


        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {   
                    var number = _service.div(
                        NumberHelper.ConvertToDecimal(firstNumber),
                        NumberHelper.ConvertToDecimal(secondNumber)
                        );
                    return Ok(number);
            }
            return BadRequest("Invalid input!");
        }
     }
}
