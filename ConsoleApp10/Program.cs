using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Road cityRoad = new Road(length: 1000, width: 20, numberOfLanes: 2);

            List<Vehicle> vehiclesOnRoad = new List<Vehicle>
        {
            new Vehicle("Car", speed: 60, size: 4),
            new Vehicle("Truck", speed: 40, size: 8),
            new Vehicle("Bus", speed: 50, size: 6)
        };

            TrafficSimulation.SimulateTraffic(cityRoad, vehiclesOnRoad);
            TrafficOptimization.OptimizeTraffic(cityRoad, vehiclesOnRoad);
        }
    }
}
