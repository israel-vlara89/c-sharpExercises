using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                if((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
            }
            string randStr = "Here are some random characters";

            foreach(char c in randStr)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
