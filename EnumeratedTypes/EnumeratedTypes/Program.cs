using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedTypes
{
    public enum Temperature
    {
        Freeze, 
        Low,
        Warm,
        Boil
    }

    class Animal
    {
        static void Main(string[] args)
        {
            Temperature micTemp = Temperature.Freeze; 

            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on freezing");
                    break;
                case Temperature.Low:
                    Console.WriteLine("Temp on low");
                    break;
                case Temperature.Warm:
                    Console.WriteLine("Temp on warm");
                    break;
                case Temperature.Boil:
                    Console.WriteLine("Temp on boiling");
                    break;

            }
            Console.ReadLine();
        }
    }
}
