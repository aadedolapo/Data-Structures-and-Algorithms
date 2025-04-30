using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
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
            GraphNode node = new GraphNode(name);
            nodes.AddLast(node);
        }

        public void AddEdge(string from, string to)
        {
            GraphNode fromNode = GetNodeByName(from); // find both nodes
            GraphNode toNode = GetNodeByName(to);
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
            int counter = 0; // intiate a counter variable set to 0
            foreach (GraphNode node in nodes) // loop through nodes list
            {
                counter += node.GetAdjList().Count; // Get the recent 
            }
            return counter;
        }

        public List<string> DisplayGraph()
        {
            List<string> allnodes = new List<string>();
            foreach (GraphNode node in nodes)
            {
                allnodes.Add(node.Name);
            }
            return allnodes;
        }
        public LinkedList<string> DisplayAdjNodes(string inputName)
        {
            LinkedList<string> adjl;
            GraphNode n = GetNodeByName(inputName);
            // Get and store in adjl the adjacency list of the node n           
            adjl = n.GetAdjList();
            return adjl;
        }

        public void RemoveNode(string name)
        { 
            GraphNode removenode = GetNodeByName(name);
            // Remove the node from the list of nodes
            nodes.Remove(removenode);
            // remove all edges
            foreach (GraphNode node in nodes)
            {
                node.GetAdjList().Remove(name);
            }
        }

        public void DepthFirstTraverse(string startID, ref List<string> visited)
        {
            LinkedList<string> adj;
            Stack<string> toVisit = new Stack<string>();
            toVisit.Push(startID);
            string currentID;

            while (toVisit.Count != 0)
            {
                currentID = toVisit.Pop(); //get id of the current node from toVisit
                if (!visited.Contains(currentID)) // check if the current id is not in visited
                {
                    visited.Add(currentID); // store id of current node in visited
                    adj = GetNodeByName(currentID).GetAdjList(); //get adj list of the current node
                    // loop through the adj list and add toVisit all node in adj list
                    foreach (string i in adj)
                    {
                        if (!visited.Contains(i) && !toVisit.Contains(i))
                        {
                            toVisit.Push(i);
                        }
                    }
                }
            }

        }
    }
}

