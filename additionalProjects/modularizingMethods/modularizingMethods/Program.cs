using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modularizingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = GetFirstNumber();

            double secondNumber = GetSecondNumber();

            double result = AddNumbers(firstNumber, secondNumber);

            PrintResult(result);

            Console.ReadKey();
            /*
            Looking at Main, you can tell what the program does. It reads two numbers, adds the results,
            and then shows the results to the user. Each of those lines is a method call. The first three
            methods—GetFirstNumber, GetSecondNumber, and AddNumbers—return a value that is
            assigned to a variable. The last method, PrintResult, performs an action without returning a 
            33
            result. Before moving to the next refactoring, let’s walk through these methods. The following
            code listing shows the GetFirstNumber method.
            */
        }
        static double GetFirstNumber()
        {
            Console.WriteLine("First Number: ");
            string firstNumberInput = Console.ReadLine();
            double firstNumber = double.Parse(firstNumberInput);
            return firstNumber;
        }
        static double GetSecondNumber()
        {
            Console.WriteLine("Second Number: ");
            string secondNumberInput = Console.ReadLine();
            double secondNumber = double.Parse(secondNumberInput);
            return secondNumber;
        }
        static double AddNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static void PrintResult(double result)
        {
            Console.WriteLine($"\nYour result is {result}.");
        }
    }
}
