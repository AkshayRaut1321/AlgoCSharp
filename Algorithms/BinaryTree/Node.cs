namespace AlgoCSharp.Algorithms.BinaryTree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }
    }
}
