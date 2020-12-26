using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    class UserInterface
    {
        public enum ActionType
        {
            Add =1,
            Subtract,
            Divide,
            Multiply
        }
        public static ActionType GetAction()
        {
            Console.WriteLine("This is a calculator application. Please choose action you want to perform:");
            Console.WriteLine("\t1. Add numbers");
            Console.WriteLine("\t2. Subtract numbers");
            Console.WriteLine("\t3. Divide numbers");
            Console.WriteLine("\t4. Multiply numbers");
            var action = (ActionType)int.Parse(Console.ReadLine());
            return action;
        }

        public static Func<double, double, double> GetSelectedAction(ActionType action)
        {
            Func<double, double, double> selectedAction = null;
            switch (action)
            {
                case ActionType.Add:
                    selectedAction = Calculator.Add;
                    break;
                case ActionType.Subtract:
                    selectedAction = Calculator.Substract;
                    break;
                case ActionType.Divide:
                    selectedAction = Calculator.Divide;
                    break;
                case ActionType.Multiply:
                    selectedAction = Calculator.Multiply;
                    break;
            }
            return selectedAction;
        }

        public static double GetResult(Func<double, double, double> selectedAction)
        {
            if (selectedAction == null) throw new ArgumentNullException("action is not chosen");
            Console.Write("enter first number: ");
            var firstNumber = double.Parse(Console.ReadLine());
            Console.Write("enter second number: ");
            var secondNumber = double.Parse(Console.ReadLine());
            var result = selectedAction(firstNumber, secondNumber);
            return result;
        }

    }
}
