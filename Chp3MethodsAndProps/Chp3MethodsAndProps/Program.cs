using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp3MethodsAndProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Number: ");

            string firstNumberInput = Console.ReadLine();
            double firstNumber = double.Parse(firstNumberInput);

            Console.Write("Second Number: ");
            string secondNumberInput = Console.ReadLine();

            double secondNumber = double.Parse(secondNumberInput);
            double result = firstNumber + secondNumber;

            Console.WriteLine($"\n\tYour result is {result}.");

            Console.ReadKey();
        }
    }
}
