using CSharp_Code_Examples.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_Code_Examples.Inheritance
{
    internal class Inheritance
    {
        //Authors: Jake Peringatt
        //Demonstrates inheritance, through a Dog class which inherits from Animal
        public static void run()
        {
            Dog dog1 = new Dog("Lucky", 4, "Golden Retriever", false);
            dog1.Sound();
            dog1.Sit();
            dog1.Describe();
        }
    }

    public class Dog:Animal {
        public bool hasSpots {  get; set; }
        public string breed { get; set; }
        public Dog(string name, int age, string breed_, bool hasSpots_) : base (name, age)
        {
            hasSpots = hasSpots_;
            breed = breed_;
        }
        public override void Sound()
        {
            Console.WriteLine(name + ": Woof woof!");
        }

        public void Sit()
        {
            Console.WriteLine(name + " has sat down");
        }

        public void Describe()
        {
            if (hasSpots)
            {
                Console.WriteLine($"{name} is a dog, who is a {breed}. {name} is {age} years old, and has spots");
            }
            else
            {
                Console.WriteLine($"{name} is a dog, who is a {breed}. {name} is {age} years old, and does not have spots");
            }
        }
    }
}
