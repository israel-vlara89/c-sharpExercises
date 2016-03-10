using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4ObjectLifetime
{
    public class Calculator
    {
        static double pi = Math.PI;
        double startAngle = 0;

        public DateTime Created { get; } = DateTime.Now;

        static Calculator()
        {
            Console.WriteLine("static Calculator()");
        }
        public Calculator()
        {
            Console.WriteLine("public Calculator()");
        }
        public Calculator(int val)
        {
            Console.WriteLine("public Calculator(int)");
        }
    }
    public class ScientificCalculator : Calculator
    {
        static double pi = Math.PI;
        double startAngle = 0;

        static ScientificCalculator()
        {
            Console.WriteLine("static ScientificCalculator()");
        }
        public ScientificCalculator() : this(0)
        {
            Console.WriteLine("public ScientificCalculator()");
        }
        public ScientificCalculator(int val)
        {
            Console.WriteLine("public ScientificCalculator(int)");
        }
        public ScientificCalculator(int val, string word) : base(val)
        {
            Console.WriteLine("public ScientificCalculator(int, string)");
        }        public double EndAngle { get; set; }

        static void Main(string[] args)
        {
            var calc1 = new ScientificCalculator();

            var calc2 = new ScientificCalculator(0, "x")
            {
                EndAngle = 360
            };

            Console.ReadKey();
        }
    }
}
