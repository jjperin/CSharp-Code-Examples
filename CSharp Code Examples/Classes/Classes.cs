using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_Code_Examples.Classes
{
    internal class Classes
    {
        //Authors: Jake Peringatt
        //To demonstrate class structure, fields, properties and class methods. A generic class to later be used for inheritance.

        public static void run()
        {
            Animal animal1 = new Animal("Jeff", 3);
            animal1.Sound();
        }
    }

    public class Animal
    {
        public string name { get; set; }
        public int age { get; set; }

        public Animal(string _name, int _age)
        {
            name = _name;
            age = _age;
        }
        public virtual void Sound()
        {
            Console.WriteLine(name + " makes a sound");
        }

        public override string ToString()
        {
            return name + ", Age " + age;
        }
    }


}
