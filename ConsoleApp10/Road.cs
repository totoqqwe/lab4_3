using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Road
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int NumberOfLanes { get; set; }
        public int TrafficLevel { get; set; }

        public Road(int length, int width, int numberOfLanes)
        {
            Length = length;
            Width = width;
            NumberOfLanes = numberOfLanes;
            TrafficLevel = 0;
        }
    }
}
