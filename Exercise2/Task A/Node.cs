using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    internal class Node
    {
        //data to be stored into the tree
        private int data;
        //left and right child of a node
        public Node Left, Right;

        // Constructors
        // the data stored in the node is item
        public Node(int item)
        {
            data = item;
            Left = null;
            Right = null;
        }
        // set a property for data 
        public int Data
        {
            set { data = value; }
            get { return data; }
        }
    }
}
