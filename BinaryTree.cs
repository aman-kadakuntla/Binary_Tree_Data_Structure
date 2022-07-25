using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_tree
{
    internal class BinaryTree
    {
        private static Node root;

        public BinaryTree()
        {
            root = null;
        }
        public void Add(int val)
        {
            root=Add(root, val);
        }
        private static Node Add(Node root,int val)
        {
            if (root==null)
            {
                root = new Node();
                root.Data = val;
                root.LeftLink = null;
                root.RightLink = null;
                return root;
            }
            else if(root.Data>val)
            {
                root.LeftLink = Add(root.LeftLink,val);
            }
            else if(root.Data<val)
            {
               root.RightLink= Add(root.RightLink, val);
            }
            return root;
        }
        public void DisplayInOrder()
        {
            DisplayInOrder(root);
        }
        private static void DisplayInOrder(Node n)
        {
            if (n == null)
                return;
            DisplayInOrder(n.LeftLink);
            Console.Write(n.Data+" ");
            DisplayInOrder(n.RightLink);
        }
        
        public void DisplayPreOrder()
        {
            DisplayPreOrder(root);
        }
        public static void DisplayPreOrder(Node n)
        {
            if (n == null)
                return;
            Console.Write(n.Data + " ");
            DisplayPreOrder(n.LeftLink);
            DisplayPreOrder(n.RightLink);
        }
        public void DisplayPostOrder()
        {
            DisplayPostOrder(root);
        }
        public static void DisplayPostOrder(Node n)
        {
            if (n == null)
                return;
            DisplayPostOrder(n.LeftLink);
            DisplayPostOrder(n.RightLink);
            Console.Write(n.Data + " ");
        }

        public void DisplayInDescendingOrder()
        {
            DisplayInDescendingOrder(root);
        }
        private static void DisplayInDescendingOrder(Node n)
        {
            if (n == null)
                return;
            DisplayInDescendingOrder(n.RightLink);
            Console.Write(n.Data +" ");
            DisplayInDescendingOrder(n.LeftLink);
        }
        public void PrintRightSubTree()
        {
            PrintRightSubTree(root.RightLink);
        }
        private static void PrintRightSubTree(Node n)
        {
            DisplayInOrder(n);
        }
        public void PrintLeftSubTree()
        {
            PrintLeftSubTree(root.LeftLink);
        }
        private static void PrintLeftSubTree(Node n)
        {
            DisplayInOrder(n);
        }

        public int PrintRootValue()
        {
            return root.Data;
        }
        public void PrintLeafNodes()
        {
            PrintLeafNodes(root);
        }

        private static void PrintLeafNodes(Node n)
        {
            if(n.LeftLink==null && n.RightLink==null)
            {
                Console.Write(n.Data + " ");
                return;
            }
            PrintLeafNodes(n.LeftLink);
            PrintLeafNodes(n.RightLink);
        }

        public void PrintOuterNodes()
        {
            Node n = root;
            while(true)
            {
                Console.Write(n.Data + " ");
                n = n.LeftLink;
                if (n == null)
                {
                    n = root.RightLink;
                    while(true)
                    {
                        Console.Write(n.Data + " ");
                        n = n.RightLink;
                        if (n == null)
                            break;
                    }
                    break;

                }
            }

        }
        
    }

}
