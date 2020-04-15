using System;

namespace BinarySearchTreeProject
{
    class Node
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}

        public Node lchild;
        public int info;
        public Node rchild;

        public Node(int i) 
        {
            info = i;
            lchild = null;
            rchild = null;
        }
    }
}
