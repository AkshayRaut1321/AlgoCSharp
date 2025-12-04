namespace AlgoCSharp.Algorithms.BinaryTree.BinarySearchTree
{
    public class BinarySearchLinked
    {
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
    }
}
