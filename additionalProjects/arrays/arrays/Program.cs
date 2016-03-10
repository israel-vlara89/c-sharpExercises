using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randNumArray;

            int[] randArray = new int[5];

            int[] randArray2 = { 1, 2, 3, 4, 5 };

            int[,] multArray = new int[5, 3]; //Multidimensional arrays

            int[,] multArray2 = { { 0, 1 }, { 4, 5 } };

            foreach(int num in multArray2)
            {
                Console.WriteLine(num);
            }

            for(int x = 0; x < multArray2.GetLength(0); x++)
            {
                for (int y = 0; y < multArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0} | {1} : {2}", x, y, multArray2[x, y]);
                }
            }

            /*

            Console.WriteLine("Where is 1 " + Array.IndexOf(randArray2, 1));//Looks for the number 1 and returns its index

            string[] names = { "Israel", "John", "Joe" };

            string nameStr = string.Join(", ", names);

            string nameArray = nameStr.Split(',');

            Console.WriteLine(nameArray);

            */

            /*

            Console.WriteLine("Array Length is " + randArray2.Length);

            Console.WriteLine("Item 0 is " + randArray2[0]);

            for (int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("Position {0} : Array number {1}", i, randArray2[i]);
            }

            foreach (int num in randArray2)
            {
                Console.WriteLine(num);
            }
            */
            Console.ReadLine();
        }
    }
}
