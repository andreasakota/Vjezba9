using Shortest_Path;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Shortest_Path {

    class Program
    {
        public static Graph BuildUndirectedGraph()
        {
            int[] nodes = { 0, 1, 2, 3, 4, 5 };
            Graph graph = new Graph(nodes);
            graph.AddEdge(0, 1, 24.0, DirectionType.Undirected);
            graph.AddEdge(0, 5, 28.0, DirectionType.Undirected);
            graph.AddEdge(1, 2, 11.0, DirectionType.Undirected);
            graph.AddEdge(2, 3, 13.0, DirectionType.Undirected);
            graph.AddEdge(3, 4, 20.0, DirectionType.Undirected);
            graph.AddEdge(3, 5, 12.0, DirectionType.Undirected);
            graph.AddEdge(4, 5, 15.0, DirectionType.Undirected);
            return graph;
        }

        public static Graph BuildDirectedGraph()
        {
            int[] nodes = { 0, 1, 2, 3, 4, 5, 6, 7 };
            Graph graph = new Graph(nodes);
            graph.AddEdge(0, 1, 9.0, DirectionType.Directed);
            graph.AddEdge(0, 5, 14.0, DirectionType.Directed);
            graph.AddEdge(0, 6, 15.0, DirectionType.Directed);
            graph.AddEdge(1, 2, 24.0, DirectionType.Directed);
            graph.AddEdge(2, 4, 2.0, DirectionType.Directed);
            graph.AddEdge(2, 7, 19.0, DirectionType.Directed);
            graph.AddEdge(3, 7, 6.0, DirectionType.Directed);
            graph.AddEdge(3, 2, 6.0, DirectionType.Directed);
            graph.AddEdge(4, 3, 11.0, DirectionType.Directed);
            graph.AddEdge(4, 7, 16.0, DirectionType.Directed);
            graph.AddEdge(5, 4, 30.0, DirectionType.Directed);
            graph.AddEdge(5, 6, 5.0, DirectionType.Directed);
            graph.AddEdge(5, 2, 18.0, DirectionType.Directed);
            graph.AddEdge(6, 4, 20.0, DirectionType.Directed);
            graph.AddEdge(6, 7, 44.0, DirectionType.Directed);
            return graph;
        }

        public static Graph BuildMixedGraph()
        {
            int[] nodes = { 0, 1, 2, 3, 4, 5, 6, 7 };
            Graph graph = new Graph(nodes);
            graph.AddEdge(0, 6, 90.0, DirectionType.Directed);
            graph.AddEdge(0, 1, 20.0, DirectionType.Directed);
            graph.AddEdge(0, 3, 80.0, DirectionType.Directed);
            graph.AddEdge(1, 5, 10.0, DirectionType.Directed);
            graph.AddEdge(2, 5, 50.0, DirectionType.Directed);
            graph.AddEdge(2, 7, 20.0, DirectionType.Directed);
            graph.AddEdge(2, 3, 10.0, DirectionType.Undirected);
            graph.AddEdge(3, 6, 20.0, DirectionType.Directed);
            graph.AddEdge(4, 1, 50.0, DirectionType.Directed);
            graph.AddEdge(4, 6, 30.0, DirectionType.Directed);
            graph.AddEdge(5, 2, 10.0, DirectionType.Directed);
            graph.AddEdge(5, 3, 40.0, DirectionType.Directed);
            graph.AddEdge(6, 0, 20.0, DirectionType.Directed);
            return graph;
        }

        static void Main(string[] args)
        {
            //Graph graph = BuildUndirectedGraph();
            //Graph graph = BuildDirectedGraph();
            Graph graph = BuildMixedGraph();
            graph.FindShortestPath();
        }

    }
}