using System;
using System.Xml.Linq;

namespace AlgoCSharp.Algorithms.BinaryTree.BinarySearchTree
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
    }
}
