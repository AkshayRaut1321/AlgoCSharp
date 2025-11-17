using AlgoCSharp.Algorithms.QueueADT;
using System;

namespace AlgoCSharp.Algorithms.BinaryTree
{
    public class BinaryTree
    {
        private LinearQueueArrayADT<BinaryTreeNode> _queueADT;

        public BinaryTreeNode Create()
        {
            Console.WriteLine("Enter size:");
            int size = Convert.ToInt32(Console.Read());
            _queueADT = new LinearQueueArrayADT<BinaryTreeNode>(size);

            Console.WriteLine("Enter root value:");
            int rootValue = Convert.ToInt32(Console.ReadLine());

            var root = new BinaryTreeNode(rootValue);
            _queueADT.Enqueue(root);

            while (!_queueADT.IsEmpty())
            {
                BinaryTreeNode currentParent = _queueADT.Dequeue();

                Console.WriteLine($"Enter {currentParent.data}'s left value:");
                int leftValue = Convert.ToInt32(Console.ReadLine());
                if (leftValue > 0)
                {
                    var leftNode = new BinaryTreeNode(leftValue);
                    currentParent.Left = leftNode;
                    _queueADT.Enqueue(leftNode);
                }

                Console.WriteLine($"Enter {currentParent.data}'s right value:");
                int rightValue = Convert.ToInt32(Console.ReadLine());
                if (rightValue > 0)
                {
                    var rightNode = new BinaryTreeNode(rightValue);
                    currentParent.Right = rightNode;
                    _queueADT.Enqueue(rightNode);
                }
            }

            return root;
        }

        public void Display(BinaryTreeNode root)
        {
            
        }
    }
}
