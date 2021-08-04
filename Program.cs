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

            List<string> rockyPlanets = new List<string>();

            var rock = planetList.GetRange(0, 4);

            rockyPlanets.AddRange(rock);

            planetList.Remove("Pluto");

            var spacecraft = new Dictionary<string, List<string>>();

            planetList.ForEach(planet => spacecraft.Add(planet, new List<string>() { "Challenger", "Viking" }));

            foreach (var (planet, probes) in spacecraft)
            {
                Console.WriteLine(planet);
                foreach (var orbiter in probes)
                {
                    Console.WriteLine($"{orbiter}");
                }
            }
        }
    }
}
