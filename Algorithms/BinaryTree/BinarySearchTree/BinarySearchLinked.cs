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

        public (BinaryTreeNode result, BinaryTreeNode parent) RecursiveSearchWithParentPointer(BinaryTreeNode node, int key, BinaryTreeNode parent)
        {
            if (node == null)
                return (null, null);

            if (node.Data == key)
                return (node, parent);

            if (key < node.Data)
                return RecursiveSearchWithParentPointer(node.Left, key, node);
            else
                return RecursiveSearchWithParentPointer(node.Right, key, node);
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

        public (BinaryTreeNode result, BinaryTreeNode parent) IterativeSearchWithParentPointer(BinaryTreeNode node, int key)
        {
            BinaryTreeNode parent = null;
            while (node != null)
            {
                parent = node;
                if (node.Data == key)
                    return (node, parent);

                if (key < node.Data)
                    node = node.Left;
                else
                    node = node.Right;
            }
            return (null, parent);
        }

        public BinaryTreeNode InsertWithIterativeSearch(int value)
        {
            if (Root == null)
                Root = new BinaryTreeNode(value);
            else
            {
                (var result, var parent) = IterativeSearchWithParentPointer(Root, value);
                if (result == null)
                {
                    var newNode = new BinaryTreeNode(value);
                    if (value < parent.Data)
                        parent.Left = newNode;
                    else
                        parent.Right = newNode;
                }
            }
            return Root;
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
    }
}
