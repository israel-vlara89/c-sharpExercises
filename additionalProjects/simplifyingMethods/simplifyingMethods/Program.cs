using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplifyingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = GetNumber("First");
            double secondNumber = GetNumber("Second");

            double result = AddNumbers(firstNumber, secondNumber);

            PrintResult(result);

            Console.ReadKey();
        }
        static double GetNumber(string whichNumber)
        {
            Console.WriteLine($"{whichNumber} Number: ");
            string numberInput = Console.ReadLine();
            double number = double.Parse(numberInput);
            return number;
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
