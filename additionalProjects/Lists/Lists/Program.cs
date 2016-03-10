using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();

            numList.Add(1);
            numList.Add(2);
            numList.Add(3);

            int[] randArray = { 1, 2, 3, 4, 5 };
            numList.AddRange(randArray);

            //numList.Clear(); This line clears the list but no reason to do that

            //Copy an array into a list 
            List<int> numList2 = new List<int>(randArray);

            //Create a list with an array 
            List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });

            //Insert item into a specific index 
            numList.Insert(1, 10);

            //Remove item specific to its name 
            numList.Remove(5);

            //Remove a specific index
            numList.RemoveAt(2); 

            //Cycle through a list 
            for(int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[1]);
            }

            Console.WriteLine("4 is in index " + numList3.IndexOf(4));

            //Check if 5 is in the list 
            Console.WriteLine("5 in List " + numList.Contains(5));

            //Search for value in a string list 
            List<string> strList = new List<string>(new string[] { "Tom", "Paul" });

            //Check to see if list contains tom regardless of case sensitivity
            Console.WriteLine("Tom in list " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));

            //Sort list 
            strList.Sort();

            Console.ReadLine();
        }
    }
}
