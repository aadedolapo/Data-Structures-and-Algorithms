using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph myGraph = new Graph(); //empty Graph
            myGraph.AddNode(1);
            myGraph.AddNode(2);
            myGraph.AddNode(3);
            myGraph.AddNode(4);
            myGraph.AddNode(5);
            myGraph.AddNode(6);
            myGraph.AddNode(7);

            myGraph.AddEdge(1, 2);
            myGraph.AddEdge(1, 4);
            myGraph.AddEdge(1, 6);
            myGraph.AddEdge(2, 3);
            myGraph.AddEdge(2, 6);
            myGraph.AddEdge(3, 5);
            myGraph.AddEdge(5, 7);
            myGraph.AddEdge(6, 7);
            myGraph.AddEdge(7, 1);
            

            Console.WriteLine(myGraph.IsEmptyGraph());
            Console.WriteLine($"Number of nodes in Graph: {myGraph.NumNodesGraph()}");
            Console.WriteLine($"Number of edges in Graph: {myGraph.NumEdgesGraph()}");
            
        }

    }
}
