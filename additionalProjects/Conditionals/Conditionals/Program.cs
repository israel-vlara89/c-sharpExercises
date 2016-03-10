using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rational Operators: > < >= <= == !=
            //Logical Operators : && || ^ !

            int age = 8;
            
            if ((age >= 5) && (age <=7))
            {
                Console.WriteLine("Go to Elementary School");
            }else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go To Middle School");
            }else
            {
                Console.WriteLine("Go to High School or College");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't be working anymore");
            }else if ((age < 18) || (age < 67))
            {
                Console.WriteLine("Get a job you lazy bum!");
            }

            Console.WriteLine("!true = " + !true);
            Console.WriteLine("!false = " + !false);

            bool canDrive = age >= 16 ? true : false; //Assigns true or false depending if the condition is either true or false

            //Switch Statements 
            switch(age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                //goto Cute;
                default:
                    Console.WriteLine("Child");
                    break;
            }

        Cute:
            Console.WriteLine("Toddlers are cute");

            Console.ReadLine();
        }
    }
}
