using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Number: ");
            string firstNumberInput = Console.ReadLine();
            double firstNumber = double.Parse(firstNumberInput);

            Console.WriteLine("Second Number: ");
            string secondNumberInput = Console.ReadLine();
            double secondNumber = double.Parse(secondNumberInput);

            double result = firstNumber + secondNumber;

            Console.WriteLine($"\n\tYout result is {result}.");

            Console.ReadKey();
        }
    }
}
