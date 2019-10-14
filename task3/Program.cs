using System;
using System.Collections.Generic;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowExpression = Console.ReadLine().Split(' ');

            Program c = new Program();
            Console.WriteLine(c.Calculate(rowExpression));
        }

        int Calculate(string[] expression)
        {
            Stack<int> stack = new Stack<int>();
            double result = 0; // condition of the task hasn't integer limits for intermideate results.
            bool isFirstOperation = true;
            foreach (string element in expression)
            {
                if (int.TryParse(element, out int number))
                    stack.Push(number);
                else
                {
                    if (isFirstOperation)
                    {
                        result = stack.Pop();
                        isFirstOperation = false;
                    }
                    result = DoMath(char.Parse(element), stack.Pop(), result);
                }
            }
            return (int)result;
        }

        double DoMath(char op, int firstNumber, double secondNumber)
        {
            switch (op)
            {
                case '+':
                    return firstNumber + secondNumber;
                case '-':
                    return firstNumber - secondNumber;
                case '*':
                    return firstNumber * secondNumber;
                case '/':
                    return firstNumber / secondNumber;
                default:
                    throw new Exception();
            }
        }
    }
}
