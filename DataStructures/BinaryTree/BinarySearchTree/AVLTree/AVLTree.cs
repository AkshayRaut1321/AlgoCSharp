using System;

namespace AlgoCSharp.DataStructures.BinaryTree.BinarySearchTree.AVLTree
{
    public class AVLTree
    {
        // ── Helpers ───────────────────────────────────────────────────────────
        int Height(AVLNode n) => n?.Height ?? 0;
        int Max(int a, int b) => a > b ? a : b;

        private void UpdateHeight(AVLNode n)
        {
            n.Height = 1 + Max(Height(n.Left), Height(n.Right));
        }

        private int BalanceFactor(AVLNode n) => n == null ? 0 : Height(n.Left) - Height(n.Right);

        // ── LL Rotation (single right rotation) ──────────────────────────────
        //
        //      z (imbalanced)          y (new root)
        //     / \                     / \
        //    y   T4     ────►        x    z
        //   / \                    / \  / \
        //  x  T3                  T1 T2 T3 T4
        // / \
        // T1 T2
        //
        private AVLNode RightRotate(AVLNode z)
        {
            AVLNode y = z.Left;
            AVLNode T3 = y.Right;

            // Perform rotation
            y.Right = z;
            z.Left = T3;

            // Update heights (z first, because y now depends on z)
            UpdateHeight(z);
            UpdateHeight(y);

            Console.WriteLine($"  Right-rotated: new subtree root = {y.Data}");
            return y;
        }

        // ── Insert with AVL rebalancing ───────────────────────────────────────
        public AVLNode Insert(AVLNode node, int key)
        {
            // 1. Standard BST insert
            if (node == null)
                return new AVLNode(key);

            if (key < node.Data)
                node.Left = Insert(node.Left, key);
            else if (key > node.Data)
                node.Right = Insert(node.Right, key);
            else
                return node; // duplicate keys not allowed

            // 2. Update height of current node
            UpdateHeight(node);

            // 3. Get balance factor to detect imbalance
            int balance = BalanceFactor(node);

            // ── LL Case ── Left-Left: right-rotate
            if (balance > 1 && key < node.Left.Data)
            {
                Console.WriteLine($"  LL imbalance detected at node {node.Data} " +
                                  $"(balance = {balance})");
                return RightRotate(node);
            }

            // ── LR Case ── Left-Right: left-rotate child, then right-rotate
            if (balance > 1 && key > node.Left.Data)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // ── RR Case ── Right-Right: left-rotate
            if (balance < -1 && key > node.Right.Data)
                return LeftRotate(node);

            // ── RL Case ── Right-Left: right-rotate child, then left-rotate
            if (balance < -1 && key < node.Right.Data)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node; // already balanced
        }

        // ── RR Rotation (single left rotation – needed for other cases) ───────
        private AVLNode LeftRotate(AVLNode z)
        {
            AVLNode y = z.Right;
            AVLNode T2 = y.Left;

            y.Left = z;
            z.Right = T2;

            UpdateHeight(z);
            UpdateHeight(y);

            Console.WriteLine($"  Left-rotated: new subtree root = {y.Data}");
            return y;
        }

        // ── In-order traversal ────────────────────────────────────────────────
        public void InOrder(AVLNode node)
        {
            if (node == null)
                return;
            InOrder(node.Left);
            Console.Write($"{node.Data}(h={node.Height}) ");
            InOrder(node.Right);
        }

        // ── Pretty-print tree ─────────────────────────────────────────────────
        public void PrintTree(AVLNode node, string prefix = "", bool isLeft = false)
        {
            if (node == null)
                return;
            string connector = isLeft ? "├── " : "└── ";
            Console.WriteLine($"{prefix}{connector}{node.Data} [bf={BalanceFactor(node)}]");
            string childPrefix = prefix + (isLeft ? "│   " : "    ");
            PrintTree(node.Left, childPrefix, true);
            PrintTree(node.Right, childPrefix, false);
        }
    }
}
