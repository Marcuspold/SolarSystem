using System;

namespace SolarSystem2
{
    class Program
    {
        public class Planets
        {
            string name;
            int mass;

            public Planets(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
            }

            public string Name { get { return name; } }

            public int Mass { get { return mass; } }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");

        }
    }
}
