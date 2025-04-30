using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_B;

namespace Task_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(4);

            root.Left = new Node(3);
            root.Right = new Node(7);
           
            BinTree mytree = new BinTree(root);
            mytree.InsertItem(1);
            mytree.InsertItem(5);
            mytree.InsertItem(9);

            Console.WriteLine("Traversing using InOrder method:");
            mytree.InOrder();
            Console.WriteLine("\n");
            Console.WriteLine("Traversing using PreOrder method:");
            mytree.PreOrder();
            Console.WriteLine("\n");
            Console.WriteLine("Traversing using PostOrder method:");
            mytree.PostOrder();
            Console.WriteLine("\n");
            Console.WriteLine($"Number of elements in the tree:{mytree.Count()}");


        }
    }
}
