using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    internal class GraphNode
    {
        private string name; // data stored in the node
        private LinkedList<string> adjList; // List of ids that are adjacent 

        public GraphNode(string name)
        {
            this.name = name;
            adjList = new LinkedList<string>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddEdge(GraphNode to)
        {
            adjList.AddLast(to.Name); // Adding the id of the node to adjacency list of this node
        }

        public LinkedList<string> GetAdjList()
        {
            return adjList;
        }
    }
}

