using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person {FirstName = "John", LastName = "Doe", Age = 25},
                new Person {FirstName = "Jane", LastName = "Doe", Age = 26},
                new Person {FirstName = "John", LastName = "Williams", Age = 40},
                new Person {FirstName = "Samantha", LastName = "Williams", Age = 35},
                new Person {FirstName = "Bob", LastName = "Walters", Age = 12}
            };

            //place each character/item of people into a collection
            var result = from p in people
                         orderby p.LastName descending
                         group p by p.LastName;
                         






            //var result = //from c in sample.ToLower() //ToLower converts all character to lower case letters
                         //where c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                         //orderby c //descending reverses alphabet order, ascending orders letters alphabetically
                         //group c by c; //allows selecting which vowels are part of the collection without repeats
                         //select c; //If using group, do not use select statement

            //loop through each character and assign it to the variable item to print it one at a time
            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " - " + item.Count());
                foreach (var p in item)
                {
                    Console.WriteLine("\t{0}, {1}", p.LastName, p.FirstName);
                }
                
            }
                
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
