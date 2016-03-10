﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4Enumerators
{
    public class Program
    {
        static void Main(string[] args)
        {

            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Jacob",
                Gender = Gender.Male
            };

            customers[1] = new Customer
            {
                Name = "Jennifer",
                Gender = Gender.Female
            };

            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };

            foreach(Customer customer in customers)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", customer.Name, GetGender(customer.Gender));
            }



            Console.ReadKey();
        }
        public static string GetGender(Gender gender)
        {
            switch(gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid Data";
            }
        }
    }
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    // 0 - unknown 
    // 1 - male 
    // 2 - female
    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
