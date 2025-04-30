using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task_B;

namespace Task_B
{
    internal class BinTree
    {
        // member
        private Node root;

        // two constructors

        // First create an empty tree
        public BinTree()
        {
            root = null;
        }

        public BinTree(Node node)
        {
            root = node;
        }

        public int Count()
        {
            return Count(root);
        }

        private int Count(Node tree)
        {
            if (tree == null)
            {
                return 0;
            }
            return 1 + Count(tree.Left) + Count(tree.Right);
        }

        private void insertItem(int item, ref Node tree)
        {
            if (tree == null)
            {
                tree = new Node(item);
            }
            else if (item < tree.Data)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item > tree.Data)
            {
                insertItem(item, ref tree.Right);
            }
        }
        public void InsertItem(int item)
        {
            insertItem(item, ref root);
        }

        private void inOrder(Node tree)
        {
            if (tree != null)
            {
                inOrder(tree.Left);
                Console.Write(tree.Data + ",");
                inOrder(tree.Right);
            }
        }

        public void InOrder() //for tree user
        {
            inOrder(root);
        }
        private void preOrder(Node tree)
        {
            if (tree != null)
            {
                Console.Write(tree.Data + ",");
                preOrder(tree.Left);
                preOrder(tree.Right);
            }
        }

        public void PreOrder()
        {
            preOrder(root);
        }

        private void postOrder(Node tree)
        {
            if (tree != null)
            {
                postOrder(tree.Left);
                postOrder(tree.Right);
                Console.Write(tree.Data + ",");
            }
        }

        public void PostOrder()
        {
            postOrder(root);
        }

        private bool contains(int item, Node tree)
        {
            if (tree == null)
            {
                return false;
            }
            if (tree.Data == item) // item found
            {
                return true;
            }
            // Recursion
            return contains(item, tree.Left) || contains(item, tree.Right);
        }
        public bool Contains(int item)
        {
            return contains(item, root);
        }

    }

}
