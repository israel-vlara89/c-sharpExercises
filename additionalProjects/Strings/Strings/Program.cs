using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string sampString = "A bunch of random words";
            string sampString2 = "More random words";

            Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));// Check if is empty
            Console.WriteLine("Is empty " + String.IsNullOrWhiteSpace(sampString));
            Console.WriteLine("String length " + sampString.Length);

            Console.WriteLine("Index of bunch " + sampString.IndexOf("bunch"));
            Console.WriteLine("2nd Word " + sampString.Substring(2, 6));
            Console.WriteLine("Strings equal " + sampString.Equals(sampString2));
            Console.WriteLine("Starts with \"A bunch\" " + sampString.StartsWith("A bunch"));
            Console.WriteLine("Ends with words " + sampString.EndsWith("words"));

            //sampString = sampString.Trim(); TrimEnd TrimStart

            sampString = sampString.Replace("words", "characters");
            sampString = sampString.Remove(0, 2); // Removes the first two characters

            string[] names = new string[3] { "John", "Joe", "Jane" };

            Console.WriteLine("Name List " + String.Join(", ", names));

            //String formatting

            string fmtStr = String.Format("{0:c}{1:00.00}(2:#.00}{3:0,0}", 1.56, 15.567, .56, 1000);
            Console.WriteLine(fmtStr);

            Console.ReadLine();
        }
    }
}
