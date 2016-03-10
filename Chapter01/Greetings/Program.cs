using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Greetings!");
            // int count = 7;
            // char keyPressed = 'Q';
            // string title = 'Weekly Report';
            //Can't assign an int to a string or a string to an int, the following lines will not compile 
            // int total = "359";
            // string message = 7;

            //There is often input from users and it comes as a string, to convert use the following methods 
            // int total = int.Parse("359");
            // string message = 7.ToString();

            //A double is a 64-bit floating point type and int is 32-bit, converting it to int is called explicit conversion 
            // double preciseLength = 5.61;
            // int roundedLength = (int)preciseLength;

            //Prefix operators change the value of the variable before assignment and postfix operators change 
            //a variable after assignment
            // int val1 = 5;
            // int val2 = ++val1; //adds 1

            // int val3 = 2;
            // int val4 = val3--; //makes val4 = 2

            //ternary operator returns buy if the expression is tru, otherwise it returns sell
            // decimal priceGain = 1.5m;
            // string action = priceGain > 2m ? "Buy" : "Sell";

            //DateTime
            // DateTime currentTime = DateTime.Now; //returns 2/13/2016 12:17:15 AM
            // string shortDateString = currentTime.ToShortDateString(); //returns 2/13/2016
            // string longDateString = currentTime.ToLongDateString(); //returns Saturday, February 13, 2016 
            // string defaultDateString = currentTime.ToString();
            // DateTime tomorrow = currentTime.AddDays(1);

            //higher presedence operates first 
            // int result = 2 + 3 * 5; //returns 17 
            // int result2 = (2 + 3) * 5; //returns 25 

            //formatting strings 
            // string name = "israel";
            // string helloViaConcatenation = "Hello " + name + "!"; //concatenation 

            // string helloViaStringFormat = string.Format("Hello, {0}!", name); //string formatting 
            // Console.WriteLine("Hello, {0}!", name); //does the same as the above 

            //string item "bread";
            //decimal amount = 2.25m;

            //Console.WriteLine($"{nameof(item)}: {item,-10} {nameof(amount)}: {amount:C}";

            //Branching statements 
            // decimal priceGain = 1.5m;
            // string action2 = "Sell";
            // if (priceGain > 2m)
            // {
            //  action2 = "Buy";
            // }

            //decimal priceGain = 2.5m;
            //string action3 = "Do nothing";
            //if (priceGain <= 2m)
            //{
            //    action3 = "Sell";
            //}
            //else
            //{
            //    action3 = "Buy";
            //}

            //string action4 = null;
            //if (priceGain <= 2m)
            //{
            //    action4 = "Sell";
            //}
            //else if (priceGain > 2m && priceGain <= 3m)
            //{
            //    action4 = "Do nothing";
            //}
            //else
            //{
            //    action4 = "Buy";
            //}

            //Switch statement
            //Console.WriteLine("Please type the current weather status, cold, rain, or sunny to see what equipment we will need");
            //string currentWeather = Console.ReadLine();
            //string equipment = null;
            //switch (currentWeather)
            //{
            //    case "sunny":
            //        equipment = "wear sunglasses";
            //        break;
            //    case "rain":
            //        equipment = "use an umbrella";
            //        break;
            //    case "cold":
            //    default:
            //        equipment = "wear a jacket";
            //        break;
            //}
            //Console.WriteLine(equipment);

            //Arrays and Collections 
            //int[] oddNumbers = { 1, 3, 5 };
            //int firstOdd = oddNumbers[0];
            //int lastOdd = oddNumbers[2];

            //This method initiates an array of string that holds 3 values but they are all null by default, names[1] assigns joe to the second value
            //string[] names = new string[3];
            //names[1] = "joe";

            //List<decimal> stockPrices = new List<decimal>();
            //stockPrices.Add(56.23m);
            //stockPrices.Add(72.80m);
            //decimal secondStockPrice = stockPrices[1];
            //Console.WriteLine(secondStockPrice);

            //LOOPING STATEMENTS
            //i starts at 0 and temperature has 4 items, while i is less that temperature's length it keeps adding 1 until i = 4 same as temperature's length
            //double[] temperatures = { 72.3, 73.8, 75.1, 74.9 };
            //for (int i = 0; i < temperatures.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //assings each number one at a time to temperature and converts it to integer
            //double[] temperatures = { 72.3, 73.8, 75.1, 74.9 };
            //foreach (int temperature in temperatures)
            //{
            //    Console.WriteLine(temperature);
            //}


            //temperatures has a length of 4 items, tempCount is = 0 while tempCount is less that temperature's length, tempCount's value increases by 1 until tempCount is equal to temperature's length
            //double[] temperatures = { 72.3, 73.8, 75.1, 74.9 };
            //int tempCount = 0;
            //while (tempCount < temperatures.Length)
            //{
            //    Console.WriteLine(tempCount);
            //    tempCount++;
            //}

            //Do While Loop
            double[] temperatures = { 72.3, 73.8, 75.1, 74.9 };
            int tempCount2 = 0;
            do
            {
                Console.WriteLine(tempCount2++);
            }
            while (tempCount2 <= temperatures.Length);


            Console.ReadLine();
        }
    }
}
