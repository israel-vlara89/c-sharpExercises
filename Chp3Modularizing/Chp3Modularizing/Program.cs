using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp3Modularizing
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
        }
        static double GetFirstNumber()
        {
            Console.Write("First Number: ");
            string firstNumberInput = Console.ReadLine();
            double firstNumber = double.Parse(firstNumberInput);
            return firstNumber;
        }
        static double GetSecondNumber()
        {
            Console.Write("Second Number: ");
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
