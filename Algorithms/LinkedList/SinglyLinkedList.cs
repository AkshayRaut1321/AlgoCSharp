namespace AlgoCSharp.Algorithms.LinkedList
{
    public class SinglyLinkedList
    {
        public int Value { get; set; }
        public SinglyLinkedList Next { get; set; }

        public SinglyLinkedList(int value)
        {
            Value = value;
        }
    }
}
