namespace AlgoCSharp.DataStructures.BinaryTree.BinarySearchTree.AVLTree
{
    public class AVLNode
    {
        public int Data;
        public AVLNode Left;
        public AVLNode Right;
        public int Height;

        public AVLNode(int data)
        {
            this.Data = data;
        }

        public override string ToString()
        {
            return this.Data.ToString();
        }
    }
}
