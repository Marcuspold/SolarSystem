using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SolarSystem
{
    class Program
    {
        public class Planets
        {
            string name;
            int mass;  
            
            public Planets(string _name , int _mass)
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
            ReadFromPlanetsFiles();
        }

        public static void ReadFromPlanetsFiles()
        {
            string FilePath = @"C:\Users\opilane\Samples";
            string FileName = @"planets.txt";

            List<Planets> planets = new List<Planets>();

            List<string> PlanetsFromFile = File.ReadAllLines(Path.Combine(FilePath, FileName)).ToList();

            

            foreach (string line in PlanetsFromFile)
            {
                string[] temparray = line.Split(new char[] { '$' }, StringSplitOptions.RemoveEmptyEntries);
                Planets newPlanet = new Planets(temparray[0], Int32.Parse(temparray[1]));
                planets.Add(newPlanet);
                Console.WriteLine(line);
            }


            foreach (Planets planet in planets)
            {
                Console.WriteLine($"Planets: {planet.Name}; Mass: {planet.Mass}");
            }
        }
    }
}
