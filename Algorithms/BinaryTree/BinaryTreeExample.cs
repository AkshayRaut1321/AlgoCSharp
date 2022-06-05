using System;

namespace AlgoCSharp.Algorithms.BinaryTree
{
    class BinaryTreeExample
    {
        public static void Run()
        {
            int[] nodes = { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
            BinaryTree binaryTree = new BinaryTree();
            Node root = binaryTree.BuildTree(nodes);
            Console.WriteLine(root);
            binaryTree.PrintByPreOrder(root);
            Console.WriteLine();
            binaryTree.PrintByInOrder(root);
        }
    }
}
