using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(4);

            root.Left = new Node(3);
            root.Right = new Node(7);
            //root.Right.Right = new Node(30);

            BinTree mytree = new BinTree(root);
            mytree.InsertItem(1);
            mytree.InsertItem(5);
            mytree.InsertItem(9);
            //mytree.InOrder();
            //Console.WriteLine("\n");
            //mytree.PreOrder();
            //Console.WriteLine("\n");
            //mytree.PostOrder();
            //Console.WriteLine("\n");
            Console.WriteLine(mytree.Contains(9));
            Console.WriteLine(mytree.Contains(10));
            Console.WriteLine(mytree.Contains(1));
            Console.WriteLine(mytree.Contains(11));
        }
    }
}
