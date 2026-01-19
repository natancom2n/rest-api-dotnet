using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RestApi2.Controllers
{

    [ApiController]
    //[Route("[controller]")]
    public class MathControllerV1 : ControllerBase //controller retorna views, para matemática usar ControllerBase
    {
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
              public IActionResult Sum(string firstNumber, string secondNumber)
        {
            
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum);
            }
                return BadRequest("Invalid input!");
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sub);
            }
            return BadRequest("Invalid input!");
        }

        [HttpGet("mul/{firstNumber}/{secondNumber}")]
        public IActionResult mul(string firstNumber, string secondNumber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mul = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(mul);
            }
            return BadRequest("Invalid input!");
        }

        [HttpGet("med/{firstNumber}/{secondNumber}")]
        public IActionResult med(string firstNumber, string secondNumber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var med = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(med);
            }
            return BadRequest("Invalid input!");
        }

        [HttpGet("square/{number}")]
        public IActionResult square(string number)
        {

            if (IsNumeric(number))
            {
                var square = Math.Sqrt(ConvertToDouble(number));
               
                return Ok(square);
            }
            return BadRequest("Invalid input!");
        }

        private double ConvertToDouble(string strNumber)
        {
            
            double doubleValue;
            if (double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out doubleValue)
             )
            {
                return doubleValue;
            }
            return 0;
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {   
                var number = ConvertToDecimal(secondNumber);
                if (number == 0)
                {
                    return BadRequest("secondNumber can be zero");
                }
                else {
                    number = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                    return Ok(number);
                }

            }
            return BadRequest("Invalid input!");
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out decimalValue)
             )
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            decimal decimalValue;
            bool isNumber = decimal.TryParse(
                strNumber, 
                //globalization para tratar ser for 10.5 ou 10,5
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out decimalValue
                );

            return isNumber;
        }
    }
}
