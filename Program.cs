using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceShips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            Console.WriteLine("Here are the planets are our solar system:");
            planetList.ForEach(planet => Console.WriteLine(planet));

            Console.WriteLine();

            List<string> rockyPlanets = new List<string>();
            var rock = planetList.GetRange(0, 4);
            rockyPlanets.AddRange(rock);

            Console.WriteLine("Here are the rocky planets in our solar system:");
            rockyPlanets.ForEach(planet => Console.WriteLine(planet));

            Console.WriteLine();
            planetList.Remove("Pluto");
            Console.WriteLine("Pluto is no longer considered a planet. It has been removed from the list of planets.");

            var spacecraft = new Dictionary<string, string>();
            spacecraft.Add("Mercury", "Messenger, Mariner");
            spacecraft.Add("Venus", "Mariner");
            spacecraft.Add("Earth", "Pioneer, Mariner, Voyager");
            spacecraft.Add("Mars", "Mariner, Viking, Dawn");
            spacecraft.Add("Jupiter", "Pioneer, Voyager, Cassini, New Horizons");
            spacecraft.Add("Saturn", "Pioneer, Voyager, Cassini");
            spacecraft.Add("Neptune", "Voyager");
            spacecraft.Add("Uranus", "Voyager");

            Console.WriteLine();

            foreach (var planet in planetList)
            {
                Console.WriteLine($"Here are probes that have orbited {planet}: ");
                    foreach(var place in spacecraft)
                {
                    if (planet == place.Key)
                    {
                        Console.WriteLine($"{place.Value}");
                    }
                }
            }
        }
    }
}
