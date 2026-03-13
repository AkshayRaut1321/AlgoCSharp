using AlgoCSharp.DataStructures.QueueADT;
using AlgoCSharp.DataStructures.StackADT;
using System;
using System.Collections.Generic;

namespace AlgoCSharp.DataStructures.BinaryTree
{
    public class BinaryTree
    {
        private LinearQueueArrayADT<BinaryTreeNode> _queueADT;
        private int _size = 0;

        public BinaryTreeNode Create()
        {
            Console.WriteLine("Enter size:");
            var sizeInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(sizeInput) || !int.TryParse(sizeInput, out _size) || _size < 0)
                return null;

            _queueADT = new LinearQueueArrayADT<BinaryTreeNode>(_size + 1);

            Console.WriteLine("Enter root value:");
            var rootInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(rootInput) || !int.TryParse(rootInput, out int rootValue) || rootValue < 0)
                return null;

            var root = new BinaryTreeNode(rootValue);
            _queueADT.Enqueue(root);

            while (!_queueADT.IsEmpty())
            {
                BinaryTreeNode currentParent = _queueADT.Dequeue();

                Console.WriteLine($"Enter {currentParent.Data}'s left value:");
                var leftInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(leftInput) && int.TryParse(leftInput, out int leftValue) && leftValue > 0)
                {
                    var leftNode = new BinaryTreeNode(leftValue);
                    currentParent.Left = leftNode;
                    _queueADT.Enqueue(leftNode);
                }

                Console.WriteLine($"Enter {currentParent.Data}'s right value:");
                var rightInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(rightInput) && int.TryParse(rightInput, out int rightValue) && rightValue > 0)
                {
                    var rightNode = new BinaryTreeNode(rightValue);
                    currentParent.Right = rightNode;
                    _queueADT.Enqueue(rightNode);
                }
            }

            return root;
        }

        public void DisplayPreOrderRecursive(BinaryTreeNode node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Data);
                DisplayPreOrderRecursive(node.Left);
                DisplayPreOrderRecursive(node.Right);
            }
        }

        public void DisplayInOrderRecursive(BinaryTreeNode node)
        {
            if (node != null)
            {
                DisplayInOrderRecursive(node.Left);
                Console.WriteLine(node.Data);
                DisplayInOrderRecursive(node.Right);
            }
        }

        public void DisplayPostOrderRecursive(BinaryTreeNode node)
        {
            if (node != null)
            {
                DisplayPostOrderRecursive(node.Left);
                DisplayPostOrderRecursive(node.Right);
                Console.WriteLine(node.Data);
            }
        }

        public void DisplayPreOrderIterative(BinaryTreeNode node)
        {
            var nodeStack = new StackArrayADT<BinaryTreeNode>(_size);
            while (!nodeStack.IsEmpty || node != null)
            {
                if (node != null)
                {
                    Console.WriteLine(node.Data);
                    nodeStack.Push(node);
                    node = node.Left;
                }
                else
                {
                    node = nodeStack.Pop();
                    node = node.Right;
                }
            }
        }

        public void DisplayInOrderIterative(BinaryTreeNode node)
        {
            var nodeStack = new StackArrayADT<BinaryTreeNode>(_size);
            while (!nodeStack.IsEmpty || node != null)
            {
                if (node != null)
                {
                    nodeStack.Push(node);
                    node = node.Left;
                }
                else
                {
                    node = nodeStack.Pop();
                    Console.WriteLine(node.Data);
                    node = node.Right;
                }
            }
        }

        public void DisplayPostOrderIterative(BinaryTreeNode node)
        {
            var nodeStack = new StackArrayADT<BinaryTreeNode>(_size);
            BinaryTreeNode lastVisited = null;

            while (!nodeStack.IsEmpty || node != null)
            {
                if (node != null)
                {
                    nodeStack.Push(node);
                    node = node.Left;
                }
                else
                {
                    var peekNode = nodeStack.StackTop;

                    // If right child exists and hasn't been processed yet → go right
                    if (peekNode.Right != null && lastVisited != peekNode.Right)
                    {
                        node = peekNode.Right;
                    }
                    else
                    {
                        // Both children done → process node
                        Console.WriteLine(peekNode.Data);
                        lastVisited = nodeStack.Pop();
                    }
                }
            }
        }

        public void DisplayLevelOrderIterative(BinaryTreeNode node)
        {
            var nodeQueue = new LinearQueueArrayADT<BinaryTreeNode>(_size + 1);
            if (node != null)
            {
                nodeQueue.Enqueue(node);
                while (!nodeQueue.IsEmpty())
                {
                    node = nodeQueue.Dequeue();
                    if (node != null)
                    {
                        Console.WriteLine(node.Data);
                        if (node.Left != null)
                        {
                            nodeQueue.Enqueue(node.Left);
                        }
                        if (node.Right != null)
                        {
                            nodeQueue.Enqueue(node.Right);
                        }
                    }
                }
            }
        }

        public int Count(BinaryTreeNode binaryTreeNode)
        {
            if (binaryTreeNode != null)
            {
                var leftCount = Count(binaryTreeNode.Left);
                var rightCount = Count(binaryTreeNode.Right);
                return leftCount + rightCount + 1;
            }
            return 0;
        }

        public int Sum(BinaryTreeNode binaryTreeNode)
        {
            if (binaryTreeNode != null)
            {
                var leftCount = Sum(binaryTreeNode.Left);
                var rightCount = Sum(binaryTreeNode.Right);
                return leftCount + rightCount + binaryTreeNode.Data;
            }
            return 0;
        }

        public int CountParentOnlyForDegree2(BinaryTreeNode binaryTreeNode)
        {
            if (binaryTreeNode != null)
            {
                var leftCount = CountParentOnlyForDegree2(binaryTreeNode.Left);
                var rightCount = CountParentOnlyForDegree2(binaryTreeNode.Right);

                if (binaryTreeNode.Left != null && binaryTreeNode.Right != null)
                    return leftCount + rightCount + 1;
                return leftCount + rightCount;
            }
            return 0;
        }

        public int CalculateHeight(BinaryTreeNode binaryTreeNode)
        {
            if (binaryTreeNode != null)
            {
                var leftCount = CalculateHeight(binaryTreeNode.Left);
                var rightCount = CalculateHeight(binaryTreeNode.Right);

                if (leftCount > rightCount)
                    return leftCount + 1;
                return rightCount + 1;
            }
            return 0;
        }

        public int CountLeafNodes(BinaryTreeNode binaryTreeNode)
        {
            if (binaryTreeNode != null)
            {
                var leftCount = CountLeafNodes(binaryTreeNode.Left);
                var rightCount = CountLeafNodes(binaryTreeNode.Right);
                if (binaryTreeNode.Left == null && binaryTreeNode.Right == null)
                    return 1;
                return rightCount + leftCount;
            }
            return 0;
        }

        public int CountNonLeafNodes(BinaryTreeNode binaryTreeNode)
        {
            if (binaryTreeNode != null)
            {
                var leftCount = CountNonLeafNodes(binaryTreeNode.Left);
                var rightCount = CountNonLeafNodes(binaryTreeNode.Right);
                if (binaryTreeNode.Left != null || binaryTreeNode.Right != null)
                    return leftCount + rightCount + 1;
                return rightCount + leftCount;
            }
            return 0;
        }

        public BinaryTreeNode BuildTree(List<int> preOrder, List<int> inOrder)
        {
            // BASE CASE
            // If either list is empty, there is nothing to build
            if (preOrder.Count == 0 || inOrder.Count == 0)
                return null;

            // STEP 1 — The first element of preOrder is always the current root
            int rootValue = preOrder[0];
            BinaryTreeNode root = new BinaryTreeNode(rootValue);

            // STEP 2 — Find the root's position in inOrder
            // Everything to its LEFT  → left subtree
            // Everything to its RIGHT → right subtree
            int rootIndexInInOrder = -1;

            for (int i = 0; i < inOrder.Count; i++)
            {
                if (inOrder[i] == rootValue)
                {
                    rootIndexInInOrder = i;
                    break;
                }
            }

            // STEP 3 — Slice the inOrder into left and right portions
            // Left inOrder  → indices 0 to rootIndex - 1
            // Right inOrder → indices rootIndex + 1 to end
            List<int> leftInOrder = new List<int>();
            List<int> rightInOrder = new List<int>();

            for (int i = 0; i < rootIndexInInOrder; i++)
                leftInOrder.Add(inOrder[i]);

            for (int i = rootIndexInInOrder + 1; i < inOrder.Count; i++)
                rightInOrder.Add(inOrder[i]);

            // STEP 4 — Slice the preOrder into left and right portions
            // We know how many nodes are in the left subtree
            // from the leftInOrder count, so we use that as the size
            // Left preOrder  → indices 1 to leftInOrder.Count  (skip index 0, that was the root)
            // Right preOrder → indices leftInOrder.Count + 1 to end
            int leftSubtreeSize = leftInOrder.Count;

            List<int> leftPreOrder = new List<int>();
            List<int> rightPreOrder = new List<int>();

            for (int i = 1; i <= leftSubtreeSize; i++)
                leftPreOrder.Add(preOrder[i]);

            for (int i = leftSubtreeSize + 1; i < preOrder.Count; i++)
                rightPreOrder.Add(preOrder[i]);

            // STEP 5 — Recurse
            // Build the left subtree using left slices
            // Build the right subtree using right slices
            root.Left = BuildTree(leftPreOrder, leftInOrder);
            root.Right = BuildTree(rightPreOrder, rightInOrder);

            // STEP 6 — Return the fully constructed root
            return root;
        }
    }
}
