using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_6
{
    class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public double weight { get; set; }

        public Animal(string Name, int Age, double Weight)
        {
            name = Name;
            age = Age;
            weight = Weight;
        }
    }

    class Tiger : Animal
    {
        public Tiger(string name, int age, double weight) : base(name, age, weight) { }
        public void Roar()
        {
            Console.WriteLine($"{name} is roaring.");
        }
    }

    class Crocodile : Animal
    {
        public Crocodile(string name, int age, double weight) : base(name, age, weight) { }
        public void Swim()
        {
            Console.WriteLine($"{name} is swimming.");
        }
    }

    class Kangaroo : Animal
    {
        public Kangaroo(string name, int age, double weight) : base(name, age, weight) { }
        public void Jump()
        {
            Console.WriteLine($"{name} is jumping.");
        }
    }
}