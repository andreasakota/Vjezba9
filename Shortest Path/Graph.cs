using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Path
{
    public class Graph : IEnumerable
    {
        internal Vertex[] vertices;
        PartiallyOrderedTree pot;

        public Graph(int[] nodes)
        {
            vertices = new Vertex[nodes.Length];
            pot = new PartiallyOrderedTree(this);
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i] = new Vertex(nodes[i]);
                vertices[i].Index = i + 1;
            }
        }

        public void AddEdge(int source, int destination, double cost, DirectionType direction)
        {
            vertices[source].AddEdge(destination, cost);
            if (direction == DirectionType.Undirected)
                vertices[destination].AddEdge(source, cost);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var vertex in vertices)
                yield return vertex;
        }

        public void Display()
        {
            foreach (var o in this)
                Console.WriteLine(o);

            pot.Display();

            Console.ReadLine();
        }

        public void FindShortestPath()
        {
            Console.Write("Enter the starting node: ");
            int start;

            // Validacija unosa
            while (!int.TryParse(Console.ReadLine(), out start) || start < 0 || start >= vertices.Length)
            {
                Console.WriteLine("Invalid input. Please enter a valid node index (0 to {0}):", vertices.Length - 1);
            }

            vertices[start].Distance = 0.0;

            for (int i = 1; i <= pot.last; i++)
            {
                pot.BubbleUp(i);
            }

            while (pot.last > 0)
            {
                int currentIndex = pot.queue[1]; 
                Vertex currentVertex = vertices[currentIndex];
                pot.Swap(1, pot.last--);        
                pot.BubbleDown(1);              

                foreach (var edge in currentVertex.Neighbors)
                {
                    int destination = edge.Destination;
                    double newDistance = currentVertex.Distance + edge.Cost;

                    if (newDistance < vertices[destination].Distance)
                    {
                        vertices[destination].Distance = newDistance; 
                        pot.BubbleUp(destination + 1);               
                    }
                }
            }

            Display(); 
        }


    }
}
