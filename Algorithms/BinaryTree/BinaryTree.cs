using System;

namespace AlgoCSharp.Algorithms.BinaryTree
{
    public class BinaryTree
    {
        static int index = -1;
        public Node BuildTree(int[] nodes)
        {
            index++;
            if (nodes[index] == -1)
                return null;

            Node newNode = new Node(nodes[index]);
            newNode.left = BuildTree(nodes);
            newNode.right = BuildTree(nodes);
            return newNode;
        }

        public void PrintByPreOrder(Node root)
        {
            if (root == null)
            {
                Console.Write("-1 ");
                return;
            }
            Console.Write(root.data + " ");
            PrintByPreOrder(root.left);
            PrintByPreOrder(root.right);
        }

        public void PrintByInOrder(Node root)
        {
            if (root == null)
            {
                Console.Write("-1 ");
                return;
            }
            PrintByInOrder(root.left);
            Console.Write(root.data + " ");
            PrintByInOrder(root.right);
        }
    }
}
