namespace AlgoCSharp.DataStructures.LinkedList
{
    public class DoublyLinkedListNode
    {
        public DoublyLinkedListNode Previous { get; set; }
        public int Value { get; set; }
        public DoublyLinkedListNode Next { get; set; }

        public DoublyLinkedListNode(int value)
        {
            Value = value;
        }
    }
}
