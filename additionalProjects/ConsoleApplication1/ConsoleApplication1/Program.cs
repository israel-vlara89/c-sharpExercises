using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter anything");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", How are you doing?");
            Console.ReadLine();

            bool canVote = true;
            char grade = 'A';

            //Integer with a max number of 2,147,483,647
            int maxint = int.MaxValue;
            Console.WriteLine("Maximum Integer: "+maxint);

            //Long with a max number of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;
            Console.WriteLine("Maximum Long: "+maxLong);

            //Decimal has a maximum value of 79,228,162,514,264,337,593,543,950,335
            //If you need something bigger look up bigInteger 
            decimal maxDec = decimal.MaxValue;
            Console.WriteLine("Maximum Decimal: "+maxDec);

            //A float is 32 bit number with a maxValue of 3.402823E+38 with 7 decimals of precision 
            float maxFloat = float.MaxValue;
            Console.WriteLine("Maximum Float: " + maxFloat);

            //A float is a 32 bit number with a maxValue of 1.797693134+308 with 16 decimals of precision
            double maxDouble = double.MaxValue;
            Console.WriteLine("Maximum Double: " + maxDouble);

            var anotherName = "John";
            Console.WriteLine("anotherNAme is a {0}",anotherName.GetTypeCode()); //Returns type data/variable



            Console.ReadLine();
        }
    }
}
