using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherStruct
{
    public struct Customer
    {
        private int _id;
        private string _name;
        private string _address;
        private string _gender;

        //Properties
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        public string Gender
        {
            get { return this._gender; }
            set { this._gender = value; }
        }

        public Customer(int Id, string Name, string Address, string Gender)
        {
            this._id = Id;
            this._name = Name;
            this._address = Address;
            this._gender = Gender;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Id = {0},  Name: {1}, Address: {2}, Gender: {3}", this._id, this._name,this._address,this._gender);
        }

    }





    public class Program
    {
        static void Main(string[] args)
        {
            //The traditional way of creating an object
            Customer C1 = new Customer(101, "Jacob", "123 se mark ave", "male");
            C1.PrintDetails();

            //Creating each at a time
            Customer C2 = new Customer();
            C2.Id = 456;
            C2.Name = "Jason";
            C2.Address = "456 nw morrison ave";
            C2.Gender = "male";

            C2.PrintDetails();

            //Object Initializer syntax
            Customer C3 = new Customer
            {
                Id = 105,
                Name = "Robert",
                Address = "789 nw jameson st",
                Gender = "male"
            };

            C3.PrintDetails();

            Console.ReadKey();
            
        }
    }
}
