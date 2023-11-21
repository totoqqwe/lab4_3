using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Vehicle : IDriveable
    {
        public string Type { get; set; }
        public int Speed { get; set; }
        public int Size { get; set; }

        public Vehicle(string type, int speed, int size)
        {
            Type = type;
            Speed = speed;
            Size = size;
        }

        public void Move()
        {
            Console.WriteLine($"{Type} is moving at a speed of {Speed} km/h");
        }

        public void Stop()
        {
            Console.WriteLine($"{Type} has stopped");
        }
    }
}
