using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace castings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Casting
            //double pi = 31.4
            //int intPi = (int)pi;

            //Math Functions 
            // Acos, Asin, Atan, Atan2, Cos, Cosh, Exp, Log, Sin, Sinh, Tan, Tanh
            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("Math.Abs(number1)" + (Math.Abs(number1))); //Absolute Value 
            Console.WriteLine("Math.Ceiling(number1)" + (Math.Ceiling(number1))); //Round up the value 
            Console.WriteLine("Math.Floor(number1)" + (Math.Floor(number1))); // Round down the value 
            Console.WriteLine("Math.Max(number1, number2)" + (Math.Max(number1, number2))); // Pass 2 numbers, return maximum of the two
            Console.WriteLine("Math.Min(number1, number2)" + (Math.Min(number1, number2))); // Return min value of the numbers passed
            Console.WriteLine("Math.Pow(number1)" + (Math.Pow(number1, 2))); // To the power of 
            Console.WriteLine("Math.Round(number1)" + (Math.Round(number1))); // Round 
            Console.WriteLine("Math.Sqrt(number1)" + (Math.Sqrt(number1))); // Square root

            //Random Numbers 
            Random rand = new Random();
            Console.WriteLine("Generate random number between 1 and 10 " + (rand.Next(1,11)));

            Console.ReadLine();
        }
    }
}
