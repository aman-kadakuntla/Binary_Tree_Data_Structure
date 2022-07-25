using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(10);
            tree.Add(5);
            tree.Add(40);
            tree.Add(1);
            tree.Add(6);
            tree.Add(35);
            tree.Add(50);
            Console.WriteLine("Root element : " + tree.PrintRootValue());
            Console.Write("Pre order traversal : ");
            tree.DisplayPreOrder();
            Console.WriteLine();
            Console.Write("In order traversal : ");
            tree.DisplayInOrder();
            Console.WriteLine();
            Console.Write("Post order traversal : ");
            tree.DisplayPostOrder();
            Console.WriteLine();
            Console.Write("Descending order : ");
            tree.DisplayInDescendingOrder();
            Console.WriteLine();
            Console.Write("Right sub tree : ");
            tree.PrintRightSubTree();
            Console.WriteLine();
            Console.Write("Left sub tree : ");
            tree.PrintLeftSubTree();
            Console.WriteLine();
            Console.Write("Leaf nodes are : ");
            tree.PrintLeafNodes();
            Console.WriteLine();
            Console.Write("Outer nodes are : ");
            tree.PrintOuterNodes();
            Console.WriteLine();
            if (tree.Search(50))
                Console.WriteLine("Element {0} found",50);
            else
                Console.WriteLine("Element {0} not found",51);
            if (tree.Search(51))
                Console.WriteLine("Element {0} found",51);
            else
                Console.WriteLine("Element {0} not found",51);
            Console.ReadLine();
        }
    }
}
