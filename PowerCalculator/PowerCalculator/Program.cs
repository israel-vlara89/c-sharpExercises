using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerCalculator
{
    public class Calculator
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
    }
    public class ScientificCalculator : Calculator
    {
        public double Power(double num, double power)
        {
            return Math.Pow(num, power);
        }
    }
    public class ProgrammerCalculator : Calculator
    {
        public int Or(int num1, int num2)
        {
            return num1 | num2;
        }
        static void Main(string[] args)
        {
            ScientificCalculator sciCalc = new ScientificCalculator();
            double powerResult = sciCalc.Power(2, 5);
            Console.WriteLine($"Scientific Calculator 2 to the power of 5: {powerResult}");
            double sciSum = sciCalc.Add(3, 3);
            Console.WriteLine($"Scientific Calculator 3 + 3: {sciSum}");

            ProgrammerCalculator prgCalc = new ProgrammerCalculator();
            double orResult = prgCalc.Or(5, 10);
            Console.WriteLine($"Programmer Calculator 5 or 10: {orResult}");

            double prgSum = prgCalc.Add(3, 3);
            Console.WriteLine($"Programmer Calculator 3 + 3: {prgSum}");

            Console.ReadKey();
        }
    }
}
