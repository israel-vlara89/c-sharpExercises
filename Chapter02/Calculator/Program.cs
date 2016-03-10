using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = 'Q';
            bool keepRunning = true;

            do
            {
                Console.WriteLine();
                Console.Write("What do you want to do? (add, subtract, multiply, divide, quit");

                string input = Console.ReadLine();
                firstChar = input[0];

                //This is used in both the if statement and the do-while loop.
                keepRunning = !(firstChar == 'q' || firstChar == 'Q');

                double firstNumber = 0;
                double secondNumber = 0;

                //If keepRunning is still true the code is executed unless keepRunnig is false
                if (keepRunning)
                {
                    Console.Write("First number: ");
                    string firstNumberInput = Console.ReadLine();
                    firstNumber = double.Parse(firstNumberInput);

                    Console.Write("Second number: ");
                    string secondNumberInput = Console.ReadLine();
                    secondNumber = double.Parse(secondNumberInput);
                }

                double result = 0;
                switch (firstChar)
                {
                    case 'a':
                    case 'A':
                        result = firstNumber + secondNumber;
                        break;
                    case 's':
                    case 'S':
                        result = firstNumber - +secondNumber;
                        break;
                    case 'm':
                    case 'M':
                        result = firstNumber * secondNumber;
                        break;
                    case 'd':
                    case 'D':
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        result = -1;
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Your result is " + result);
            } while (keepRunning);
        }
    }
}
