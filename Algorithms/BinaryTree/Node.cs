namespace AlgoCSharp.Algorithms.BinaryTree
{
    public class BinaryTreeNode
    {
        public int data;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;

        public BinaryTreeNode(int data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }
    }
}
