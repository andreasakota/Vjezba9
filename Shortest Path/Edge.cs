using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Path
{
    public enum DirectionType { Directed, Undirected }

    public class Edge
    {
        public int Destination { get; set; }
        public double Cost { get; set; }

        public Edge(int destination, double cost)
        {
            Destination = destination;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"[{Destination}, {Cost}]";
        }
    }
}
