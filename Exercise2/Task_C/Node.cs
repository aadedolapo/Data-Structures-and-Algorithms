using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    internal class Node
    {
        //data to be stored into the tree
        private string data;
        //left and right child of a node
        public Node Left, Right;

        // Constructors
        // the data stored in the node is item
        public Node(string item)
        {
            data = item;
            Left = null;
            Right = null;
        }
               // set a property for data 
        public string Data
        {
            set { data = value; }
            get { return data; }
        }
    }
}
