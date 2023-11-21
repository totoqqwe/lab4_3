using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class TrafficOptimization
    {
        public static void OptimizeTraffic(Road road, List<Vehicle> vehicles)
        {
            Console.WriteLine($"Optimizing traffic on road of length {road.Length}m, width {road.Width}m, with {road.NumberOfLanes} lanes:");

            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }

            Console.WriteLine();
        }
    }
}
