using CSharp_Code_Examples.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples.Collections
{
    internal class Collections
    {
        //Authors: Jake Peringatt
        //Demonstrates Lists, storing them and iterating through them, interacting with the individual objects in the list

        public static void run()
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Bella", 5, "Cockapoo", false));
            dogs.Add(new Dog("Spotty", 3, "Dalmatian", true));
            dogs.Add(new Dog("Jack", 10, "Yorkshire Terrier", false));

            Console.WriteLine($"There are {dogs.Count} dogs in this list");

            Console.WriteLine("Let us describe each dog and make them bark");

            foreach(Dog dog in dogs)
            {
                dog.Describe();
                dog.Sound();
            }
        }
    }
}
