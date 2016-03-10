using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc4 = new Calculator4();
            calc4.GetNumber("First");
            calc4.GetNumber("Second");
            calc4.AddNumbers();
            PrintResult(calc4);
            Console.ReadKey();
        }
        static void PrintResult(Calculator4 calc)
        {
            Console.WriteLine($"Your result is {result}.");
        }
    }
}
