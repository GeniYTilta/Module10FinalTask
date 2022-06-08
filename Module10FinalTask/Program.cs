using System;

namespace Module10FinalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.NumbersInput(out int num1, out int num2);
            ((ICalculator)calculator).Sum(num1,num2);
        }
    }
}
