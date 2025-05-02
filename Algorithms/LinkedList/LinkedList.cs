namespace AlgoCSharp.Algorithms.LinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }

    public class LinkedListProgram
    {
        public Node LinearSearch(Node head, int key)
        {
            if (head == null || head.Value == key)
                return head;

            Node current = head.Next;
            while (current != null)
            {
                if (current.Value == key)
                    return current;
                current = current.Next;
            }
            return null;
        }

        public Node LinearSearchTransposition(Node head, int key)
        {
            if (head == null || head.Value == key)
                return head;

            Node previous = head;
            Node current = previous.Next;

            while (current != null)
            {
                if (current.Value == key)
                {
                    int temp = current.Value;
                    current.Value = previous.Value;
                    previous.Value = temp;
                    return current;
                }
                current = current.Next;
                previous = previous.Next;
            }
            return null;
        }

        public Node LinearSearchMoveToFirst(Node head, int key)
        {
            if (head == null || head.Value == key)
                return head;

            Node headCopy = head;
            Node previous = head;
            Node current = head.Next;

            while (current != null)
            {
                if (current.Value == key)
                {
                    previous.Next = current.Next;
                    current.Next = headCopy;
                    head = current;
                    return current;
                }
                current = current.Next;
                previous = previous.Next;
            }
            return null;
        }
    }
}
