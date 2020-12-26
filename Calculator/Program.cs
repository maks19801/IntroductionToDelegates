using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var action = UserInterface.GetAction();
            var selectedAction = UserInterface.GetSelectedAction(action);
            var result = UserInterface.GetResult(selectedAction);
            Console.WriteLine("Result of calculation is: " + result);
            
        }
    }
}
