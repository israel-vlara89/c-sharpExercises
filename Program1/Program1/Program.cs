using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user to enter name 
            Console.WriteLine("Enter your name please:");
            //Now read the name entered
            string name = Console.ReadLine();
            //Greet the user with the name that was entered
            if (name == "Israel")
            {
                Console.WriteLine("You are Israel!, Welcome to the program.");
            }
            else
            {
                Console.WriteLine("You are not Israel, shooo away with you pest!");
            }
            //Wait for user to acknowledge results
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
