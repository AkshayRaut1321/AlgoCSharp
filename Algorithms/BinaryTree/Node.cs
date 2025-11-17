namespace AlgoCSharp.Algorithms.BinaryTree
{
    public class BinaryTreeNode
    {
        public int Data;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;

        public BinaryTreeNode(int data)
        {
            this.Data = data;
        }

        public override string ToString()
        {
            return this.Data.ToString();
        }
    }
}
