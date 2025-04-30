using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Node root = new Node("hello");
            root.Left = new Node("from");
            root.Right = new Node("join");

            BinTree mytree = new BinTree(root);
            mytree.InsertItem("done");
            mytree.InsertItem("idea");
            mytree.InsertItem("lime");
            mytree.InsertItem("ants");
            mytree.InsertItem("waif");
            
            mytree.PostOrder();
            Console.WriteLine();
            Console.WriteLine($"Number of items in the tree: {mytree.Count()}");

            Console.WriteLine($"The longest string in the tree: {mytree.Longest()}");
            Console.WriteLine(mytree.Ancestor("waif", "idea"));
            Console.WriteLine(mytree.Ancestor("waif", "done"));
        }
    }
}
