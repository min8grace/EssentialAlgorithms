using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryTreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Node[] nodes = new Node[number+1];


            for(int i = 0; i <= number; i++)
            {
                nodes[i] = new Node(i, null, null);
            }

            for (int i = 1; i <= number; i++)
            {
                if(i%2 == 0)
                {
                    nodes[i / 2].leftChild = nodes[i];
                }
                else
                {
                    nodes[i / 2].rightChild = nodes[i];
                }
            }
            Console.WriteLine("preorder: ");
            preorder(nodes[1]); Console.WriteLine();
            Console.WriteLine("inorder: ");
            inorder(nodes[1]); Console.WriteLine();
            Console.WriteLine("postorder: ");
            postorder(nodes[1]);
        }

        public static void preorder(Node ptr)
        {
            if (ptr != null) {
                Console.Write(ptr.data+" ");
                preorder(ptr.leftChild);
                preorder(ptr.rightChild);
            }
        }

        public static void inorder(Node ptr)
        {
            if (ptr != null)
            {
                inorder(ptr.leftChild);
                Console.Write(ptr.data + " ");
                inorder(ptr.rightChild);
            }
        }

        public static void postorder(Node ptr)
        {
            if (ptr != null)
            {
                preorder(ptr.leftChild);
                postorder(ptr.rightChild);
                Console.Write(ptr.data + " ");
            }
        }
    }

    public class Node
    {
        public int data;
        public Node leftChild;
        public Node rightChild;
        public Node(int _data, Node _leftChild, Node _rightChild)
        {
            data = _data;
            leftChild = _leftChild;
            rightChild = _rightChild;
        }
    }
}
