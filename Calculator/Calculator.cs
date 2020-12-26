using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    public class Calculator
    {
        public static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static double Substract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)  throw new DivideByZeroException("You can't divide by zero"); 
            return firstNumber / secondNumber;
        }
        public static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
