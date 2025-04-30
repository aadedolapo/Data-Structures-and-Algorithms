using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    internal class GraphNode
    {
        private int id; // data stored in the node
        private LinkedList<int> adjList; // List of ids that are adjacent

        public GraphNode(int id)
        {
            this.id = id;
            adjList = new LinkedList<int>();
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public void AddEdge(GraphNode node)
        {
            adjList.AddLast(node.ID); // Adding the id of the node to adjacency list of this node
        }
        public void RemoveEdge(int node)
        {
            adjList.Remove(node);
        }
        public LinkedList<int> GetAdjList()
        {
            return adjList;
        }
    }
}
