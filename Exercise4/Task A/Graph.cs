using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_A
{
    internal class Graph
    {
        private LinkedList<GraphNode> nodes; // a list of all graphnodes
        
        public Graph()
        {
            nodes = new LinkedList<GraphNode>(); // Empty list of nodes for the graph
        }

        public GraphNode GetNodeByID(int id)
        {
            foreach (GraphNode n in nodes)
            {
                if (id == n.ID) // find nodes n with the specicif id and return n
                    return n;
            }
            return null; // the  node has not been found
        }

        public void AddNode(int id)
        {
            GraphNode node = new GraphNode(id);
            nodes.AddLast(node);
        }

        public void AddEdge(int from, int to)
        {
            GraphNode fromNode = GetNodeByID(from); // find both nodes
            GraphNode toNode = GetNodeByID(to);
            fromNode.AddEdge(toNode);
        }

        public bool IsEmptyGraph()
        {
            //if the number of the element witihin the list is equal to o
            return nodes.Count == 0;
        }

        public int NumNodesGraph()
        {
            // count all elements in the list
            return nodes.Count;
        }

        public int NumEdgesGraph()
        {
            int counter = 0; // sets numedge variable as 0
            foreach (GraphNode node in nodes) // for each Person is our linkedlist called nodes
            {
                counter += node.GetAdjList().Count;
            }
            return counter;
        }
    }
}
