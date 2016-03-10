using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2}lbs and likes to say {3}", name, height, weight, sound);
        }


        //Method Overloading
        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }




        static void Main(string[] args)
        {
            /*
            Animal spot = new Animal(15, 10, "Spot", "Woof Woof!");

            Console.WriteLine("{0} says {1}", spot.name, spot.sound);

            Console.WriteLine("Number of animals " + Animal.getNumOfAnimals());

            Console.WriteLine(spot.toString());

            Console.WriteLine(spot.getSum(num1: 1.4, num2: 2.7));

            //Another way to create an object 
            Animal grover = new Animal
            {
                name = "Grover",
                height = 16,
                weight = 18,
                sound = "Meow"
            };

            Dog spike = new Dog();

            Console.WriteLine(spike.toString());

            //Override Method
            spike = new Dog(20, 15, "Spike", "Grrrrrwooof!", "Sausages");

            Console.WriteLine(spike.toString());
            */

            /*
            //Polymorphism through abstract class
            Shape rect = new Rectangle(5, 5);
            Shape tri = new Triangle(5,5);

            Console.WriteLine("Rect Area " + rect.area());
            Console.WriteLine("Tri Area " + tri.area());

            //More overloading
            Rectangle combRect = new Rectangle(5, 5) + new Rectangle(5, 5);

            Console.WriteLine("combRect Area " + combRect.area());
            */


            //Generic Classes 
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");

            superman.key = "Superman";
            superman.value = "Clark Kent";

            KeyValue<int, string> lgSmartPhone = new KeyValue<int, string>(0, "");

            lgSmartPhone.key = 450;
            lgSmartPhone.value = "LG V10";

            superman.showData();
            lgSmartPhone.showData();

            Console.ReadKey();
        }
    }
    //Subclass
    class Dog : Animal
    {
        public string favFood { get; set; }

        public Dog() :base()
        {
            this.favFood = "No Favorite";
        }
        public Dog(double height, double weight, string name, string sound, string favFood):base(height,weight,name,sound)
        {
            this.favFood = favFood;
        }

        //Override Method
        new public string toString()
        {
            return String.Format("{0} is {1} inchess tall, weighs {2} lbs and likes to say {3} and eats {4}", name, height, weight, sound, favFood);
        }
    }
    //Abstract classes and polymorphism
    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    }
    //Interface
    public interface ShapeItem
    {
        //Every method inside an interface is an abstract method
        double area();
    }
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        public override double area()
        {
            return length * width;
        }

        //Add rectangles (Operator Overloading)
        public static Rectangle operator+ (Rectangle rect1, Rectangle rect2)
        {
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;

            return new Rectangle(rectLength, rectWidth);
        }


    }
    class Triangle : Shape
    {
        private double theBase;
        private double height;

        public Triangle(double num1, double num2)
        {
            theBase = num1;
            height = num2;
        }

        public override double area()
        {
            return .5 * (theBase * height);
        }
    }
    //Generic classes
    class KeyValue<TKey,TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }
        public void showData()
        {
            Console.WriteLine("{0} is {1}", this.key, this.value);
        }
    }
}
