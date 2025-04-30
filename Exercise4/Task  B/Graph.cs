using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__B
{
    internal class Graph
    {
        private LinkedList<GraphNode> nodes; // a list of all graphnodes

        public Graph()
        {
            nodes = new LinkedList<GraphNode>(); // Empty list of nodes for the graph
        }

        public GraphNode GetNodeByName(string name)
        {
            foreach (GraphNode n in nodes)
            {
                if (name == n.Name) // find nodes n with the specicif id and return n
                    return n;
            }
            return null; // the  node has not been found
        }

        public void AddNode(string name)
        {
            GraphNode node = new GraphNode(name); // assign name to a new variable of type GraphNode
            nodes.AddLast(node); // add node to nodes list
        }

        public void AddEdge(string from, string to)
        {
            // find both nodes
            GraphNode fromNode = GetNodeByName(from); 
            GraphNode toNode = GetNodeByName(to);
            fromNode.AddEdge(toNode); // add direct adges to adjacent list
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
            int counter = 0; // intiate a counter variable set to 0
            foreach (GraphNode node in nodes) // loop through nodes list
            {
                counter += node.GetAdjList().Count; // Get the recent 
            }
            return counter;
        }

        public List<string> DisplayGraph()
        {
            List<string> allnodes = new List<string>(); // assign a new list
            foreach (GraphNode node in nodes) // loop through all nodes in the list
            {
                allnodes.Add(node.Name); // add each node to the allnodes list
            }
            return allnodes;
        }

        // To retrun all adjacent nodes of a node
        public LinkedList<string>  DisplayAdjNodes(string inputName)
        {
            LinkedList<string> adjl;
            GraphNode n = GetNodeByName(inputName);
            // Get and store in adjl the adjacency list of the node n           
            adjl = n.GetAdjList();
            return adjl;
        }
    }
}
