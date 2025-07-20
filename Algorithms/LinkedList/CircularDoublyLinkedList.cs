namespace AlgoCSharp.Algorithms.LinkedList
{
    public class CircularDoublyLinkedList
    {
        public CircularDoublyLinkedList Previous { get; set; }
        public int Value { get; set; }
        public CircularDoublyLinkedList Next { get; set; }

        public CircularDoublyLinkedList(int value)
        {
            Value = value;
        }
    }
}
