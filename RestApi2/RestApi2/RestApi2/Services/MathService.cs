namespace RestApi2.Services
{
    public class MathService
    {
        public decimal Sum(decimal firstNumber, decimal secondNumber) => firstNumber + secondNumber;
        public decimal Sub(decimal firstNumber, decimal secondNumber) => secondNumber - firstNumber;

        public decimal Mul(decimal firstNumber, decimal secondNumber) => firstNumber * secondNumber;

        public decimal Med(decimal firstNumber, decimal secondNumber) => (firstNumber - secondNumber) / 2;
        public decimal Square(decimal number)
        {
            if (number < 0) throw new ArgumentException("Número negativo não possui raiz quadrada real");
            //return Math.Sqrt((double)number);
           return (decimal)Math.Sqrt(Convert.ToDouble(number));
        }
        public decimal div(decimal firstNumber, decimal secondNumber)
        {
            if (secondNumber == 0) throw new DivideByZeroException("Divisão por zero não permitida");
            return firstNumber / secondNumber;

        }
    }
}
