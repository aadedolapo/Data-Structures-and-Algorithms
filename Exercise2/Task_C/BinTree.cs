using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task_C;

namespace Task_C
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

        private void insertItem(string item, ref Node tree)
        {
            if (tree == null)
            {
                tree = new Node(item);
            }
            else if (item.Length <= tree.Data.Length)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.Length > tree.Data.Length)
            {
                insertItem(item, ref tree.Right);
            }
        }
        public void InsertItem(string item)
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

        private bool contains(string item, Node tree)
        {
            if (tree == null)
            {
                return false;
            }
            if (item == tree.Data) // item found
            {
                return true;
            }
            // Recursion
            return contains(item, tree.Left) || contains(item, tree.Right);
        }
        public bool Contains(string item)
        {
            return contains(item, root);
        }

        private string longest(Node tree)
        {
            string longestword = "";
            if (tree == null)
            {
                return longestword;
            }
            if (tree.Data.Length > longestword.Length)
            {
                longestword = tree.Data;
            }
            if (longest(tree.Left).Length > longestword.Length)
            {
                longestword = longest(tree.Left);   
            }
            if (longest(tree.Right).Length > longestword.Length)
            {
                longestword = longest(tree.Right);
            }
            return longestword;
        }
        public string Longest()
        {
            return longest(root);
        }

        private string ancestor(string str1, string str2, Node tree)

        {
            if (tree == null)
            {
                return "Empty Tree";
            }
            if (str1.CompareTo(tree.Data) < 0 && str2.CompareTo(tree.Data) < 0)
            {
                return ancestor(str1, str2, tree.Left);
            }
            if (str1.CompareTo(tree.Data) > 0 && str2.CompareTo(tree.Data) > 0)
            {
                return ancestor(str1, str2, tree.Right);
            }
            return tree.Data;
        }

        public string Ancestor(string str1, string str2)
        {
            // Check if both nodes are present in the tree
            if (!contains(str1, root) || !contains(str2, root))
            {
                return "Couldn't find both strings";
            }
            return ancestor(str1, str2, root);
        }



        //private static Node AncestorHelper(Node current, string node1, string node2)
        //{
        //    // Base case: if current node is null or is one of the nodes being searched for, return current node
        //    if (current == null || current.value == node1 || current.value == node2)
        //    {
        //        return current;
        //    }

        //    // Recursive case: search left and right subtrees for the two nodes
        //    Node left = AncestorHelper(current.left, node1, node2);
        //    Node right = AncestorHelper(current.right, node1, node2);

        //    // If both nodes are present in different subtrees, return the current node
        //    if (left != null && right != null)
        //    {
        //        return current;
        //    }

        //    // Otherwise, return the non-null node (i.e., the node that is present in the tree)
        //    return left ?? right;
        //}

    }

}
