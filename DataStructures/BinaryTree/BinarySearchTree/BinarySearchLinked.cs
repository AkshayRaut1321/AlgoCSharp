using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AlgoCSharp.DataStructures.BinaryTree.BinarySearchTree
{
    public class BinarySearchLinked
    {
        public BinaryTreeNode Root { get; set; }

        public BinaryTreeNode RecursiveSearch(BinaryTreeNode root, int key)
        {
            if (root == null)
                return null;

            if (root.Data == key)
                return root;

            if (key < root.Data)
                return RecursiveSearch(root.Left, key);
            else
                return RecursiveSearch(root.Right, key);
        }

        public (BinaryTreeNode result, BinaryTreeNode parent) RecursiveSearchWithTailPointer(BinaryTreeNode node, int key, BinaryTreeNode tail)
        {
            if (node == null)
                return (null, null);

            if (node.Data == key)
                return (node, tail);

            if (key < node.Data)
                return RecursiveSearchWithTailPointer(node.Left, key, node);
            else
                return RecursiveSearchWithTailPointer(node.Right, key, node);
        }

        public BinaryTreeNode IterativeSearch(BinaryTreeNode root, int key)
        {
            while (root != null)
            {
                if (root.Data == key)
                    return root;

                if (key < root.Data)
                    root = root.Left;
                else
                    root = root.Right;
            }
            return null;
        }

        public (BinaryTreeNode result, BinaryTreeNode parent) IterativeSearchWithTailPointer(BinaryTreeNode node, int key)
        {
            BinaryTreeNode tail = null;
            while (node != null)
            {
                tail = node;
                if (node.Data == key)
                    return (node, tail);

                if (key < node.Data)
                    node = node.Left;
                else
                    node = node.Right;
            }
            return (null, tail);
        }

        public BinaryTreeNode InsertWithIterativeSearch(int value)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode(value);
                return Root;
            }
            else
            {
                (var result, var tail) = IterativeSearchWithTailPointer(Root, value);
                if (result == null)
                {
                    var newNode = new BinaryTreeNode(value);
                    if (value < tail.Data)
                        tail.Left = newNode;
                    else
                        tail.Right = newNode;
                    return newNode;
                }
                return tail;
            }
        }

        public BinaryTreeNode InsertWithRecursiveSearch(BinaryTreeNode node, int value)
        {
            if (node == null)
            {
                node = new BinaryTreeNode(value);
            }
            else if (value < node.Data)
                node.Left = InsertWithRecursiveSearch(node.Left, value);
            else
                node.Right = InsertWithRecursiveSearch(node.Right, value);

            return node;
        }

        public BinaryTreeNode InsertWithRecursiveSearchTailPointer(BinaryTreeNode node, int value)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode(value);
                return Root;
            }
            else
            {
                (var result, var tail) = RecursiveSearchWithTailPointer(Root, value, null);
                if (result == null)
                {
                    var newNode = new BinaryTreeNode(value);
                    if (value < tail.Data)
                        tail.Left = newNode;
                    else
                        tail.Right = newNode;
                    return newNode;
                }
                return tail;
            }
        }

        public void InOrderDisplay(BinaryTreeNode root)
        {
            if (root != null)
            {
                InOrderDisplay(root.Left);
                Console.WriteLine(root.Data);
                InOrderDisplay(root.Right);
            }
        }

        // ==========================
        // DELETE USING SUCCESSOR
        // ==========================
        public BinaryTreeNode DeleteUsingSuccessor(BinaryTreeNode root, int key)
        {
            if (root == null)
                return null;

            if (key < root.Data)
                root.Left = DeleteUsingSuccessor(root.Left, key);

            else if (key > root.Data)
                root.Right = DeleteUsingSuccessor(root.Right, key);

            else
            {
                // Case 1: No child
                if (root.Left == null && root.Right == null)
                    return null;

                // Case 2: One child
                if (root.Left == null)
                    return root.Right;

                if (root.Right == null)
                    return root.Left;

                // Case 3: Two children
                BinaryTreeNode successor = FindMin(root.Right);
                root.Data = successor.Data;
                root.Right = DeleteUsingSuccessor(root.Right, successor.Data);
            }

            return root;
        }
        private BinaryTreeNode FindMin(BinaryTreeNode node)
        {
            while (node.Left != null)
                node = node.Left;
            return node;
        }

        // ==========================
        // DELETE USING PREDECESSOR
        // ==========================
        public BinaryTreeNode DeleteUsingPredecessor(BinaryTreeNode root, int key)
        {
            if (root == null)
                return null;

            if (key < root.Data)
                root.Left = DeleteUsingPredecessor(root.Left, key);

            else if (key > root.Data)
                root.Right = DeleteUsingPredecessor(root.Right, key);

            else
            {
                if (root.Left == null && root.Right == null)
                    return null;

                if (root.Left == null)
                    return root.Right;

                if (root.Right == null)
                    return root.Left;

                BinaryTreeNode predecessor = FindMax(root.Left);
                root.Data = predecessor.Data;
                root.Left = DeleteUsingPredecessor(root.Left, predecessor.Data);
            }

            return root;
        }

        private BinaryTreeNode FindMax(BinaryTreeNode node)
        {
            while (node.Right != null)
                node = node.Right;
            return node;
        }

        public BinaryTreeNode BuildFromPreOrder(List<int> preOrder)
        {
            if (preOrder == null || preOrder.Count == 0)
                return null;

            // Step 1: First element is always the root
            BinaryTreeNode root = new BinaryTreeNode(preOrder[0]);
            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();

            // Step 2: Iterate through remaining elements
            for (int i = 1; i < preOrder.Count; i++)
            {
                int current = preOrder[i];
                BinaryTreeNode newNode = new BinaryTreeNode(current);
                BinaryTreeNode temp = root;

                // Step 3: Traverse to find correct position
                while (true)
                {
                    if (current < temp.Data)
                    {
                        // Go LEFT
                        if (temp.Left == null)
                        {
                            // Found the spot — link as left child
                            temp.Left = newNode;

                            // Push the PARENT onto stack (left subtree ancestor)
                            stack.Push(temp);

                            break;
                        }
                        else
                        {
                            temp = temp.Left;
                        }
                    }
                    else
                    {
                        // Go RIGHT
                        if (temp.Right == null)
                        {
                            // Found the spot — link as right child
                            // Do NOT push onto stack (right subtree)
                            temp.Right = newNode;
                            break;
                        }
                        else
                        {
                            temp = temp.Right;
                        }
                    }
                }
            }

            return root;
        }

        // Helper: Pre-Order print to verify
        public void PrintPreOrder(BinaryTreeNode node)
        {
            if (node == null)
                return;
            Console.Write(node.Data + " ");
            PrintPreOrder(node.Left);
            PrintPreOrder(node.Right);
        }

        public BinaryTreeNode BuildFromPostOrder(List<int> postOrder)
        {
            if (postOrder == null || postOrder.Count == 0)
                return null;

            // Step 1: Last element is always the root
            BinaryTreeNode root = new BinaryTreeNode(postOrder[postOrder.Count - 1]);
            BinaryTreeNode temp = root;

            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();

            // Step 2: Read post-order from RIGHT TO LEFT (skip last element, already root)
            for (int i = postOrder.Count - 2; i >= 0; i--)
            {
                int current = postOrder[i];
                BinaryTreeNode newNode = new BinaryTreeNode(current);
                temp = root; // Reset temp to root for each new element

                // Step 3: Traverse to find correct position
                while (true)
                {
                    if (current > temp.Data)
                    {
                        // Go RIGHT
                        if (temp.Right == null)
                        {
                            // Found the spot — link as right child
                            temp.Right = newNode;

                            // Push the PARENT onto stack (right subtree ancestor)
                            stack.Push(temp);

                            break;
                        }
                        else
                        {
                            temp = temp.Right;
                        }
                    }
                    else
                    {
                        // Go LEFT
                        if (temp.Left == null)
                        {
                            // Found the spot — link as left child
                            // Do NOT push onto stack (left subtree)
                            temp.Left = newNode;
                            break;
                        }
                        else
                        {
                            temp = temp.Left;
                        }
                    }
                }
            }

            return root;
        }

        // Helper: Post-Order print to verify
        public void PrintPostOrder(BinaryTreeNode node)
        {
            if (node == null) return;
            PrintPostOrder(node.Left);
            PrintPostOrder(node.Right);
            Console.Write(node.Data + " ");
        }
    }
}
