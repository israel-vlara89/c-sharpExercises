using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess;

            do
            {
                Console.WriteLine("Guess a number");
                guess = Console.ReadLine();
            } while (!guess.Equals("15"));

            //For Loop 
            for (int i = 0; i < 10; i++)
            {
                if ((i %2 >) 0)
                {
                Console.WriteLine(i);
                }
            }
        }
    }
}
