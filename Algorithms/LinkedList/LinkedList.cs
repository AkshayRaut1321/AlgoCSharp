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
        public Node First { get; set; }
        public Node Last { get; set; }

        public int Count { get; internal set; }

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

        public void InsertAt(Node head, int position, int data)
        {
            Node newNode = new Node(data);
            if (position == 0)
            {
                newNode.Value = data;
                head = newNode;
            }
            else if (position > 0)
            {
                Node iteratorNode = head;
                for (int iterator = 0; iterator < position - 1 && iteratorNode != null; iterator++)
                {
                    iteratorNode = iteratorNode.Next;
                }
                if (iteratorNode != null)
                {
                    newNode.Next = iteratorNode.Next;
                    iteratorNode.Next = newNode;
                }
            }
            Count++;
        }

        public void InsertLast(int data)
        {
            Node newNode = new Node(data);

            if (First == null)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            Count++;
        }

        public void InsertSorted(int data)
        {
            Node newNode = new Node(data);

            Node traverseNode = First;
            Node previousNode = null;

            while (traverseNode != null)
            {
                if (traverseNode.Value > data && previousNode != null)
                {
                    previousNode.Next = newNode;
                    newNode.Next = traverseNode;
                    break;
                }
                previousNode = traverseNode;
                traverseNode = traverseNode.Next;
            }
            Count++;
        }

        public void DeleteByValue(int data)
        {
            Node previousNode = First;
            Node traverseNode = First.Next;

            if (First.Value == data)
            {
                First = First.Next;
                return;
            }

            while (traverseNode != null)
            {
                if (traverseNode.Value == data)
                {
                    previousNode.Next = traverseNode.Next;
                    if (previousNode.Next == null)
                        Last = previousNode;
                    break;
                }
                previousNode = traverseNode;
                traverseNode = traverseNode.Next;
            }
            Count--;
        }

        public void RemoveDuplicatesFromSorted()
        {
            Node previousNode = First;
            Node traverseNode = First.Next;

            while (traverseNode != null)
            {
                if (previousNode.Value == traverseNode.Value)
                {
                    previousNode.Next = traverseNode.Next;
                    Count--;
                }
                else
                {
                    previousNode = traverseNode;
                }
                traverseNode = traverseNode.Next;
            }
        }

        public void ReverseByElements()
        {
            Node traverseNode = First;
            int i = 0;
            int[] array = new int[Count];

            while (traverseNode != null)
            {
                array[i] = traverseNode.Value;
                traverseNode = traverseNode.Next;
                i++;
            }

            traverseNode = First;
            i--;

            while (traverseNode != null)
            {
                traverseNode.Value = array[i];
                traverseNode = traverseNode.Next;
                i--;
            }
        }

        public void ReverseByLinks()
        {
            // previous will hold the last reversed node
            Node previous = null;

            // current will point to the node being processed
            Node current = null;

            // next starts at the head of the list
            Node next = First;

            // Traverse the list and reverse the links one by one
            while (next != null)
            {
                previous = current;        // Move previous one step forward
                current = next;            // Move current to the node to process
                next = next.Next;          // Advance next before breaking the link

                current.Next = previous;   // Reverse the current node's link
            }

            // Finally, set the head (First) to the new front of the list
            First = current;
        }

        public void ReverseUsingTailRecursion(Node previous, Node next)
        {
            if (next != null)
            {
                ReverseUsingTailRecursion(next, next.Next);
                next.Next = previous;
            }
            else
            {
                First = previous;
            }
        }

        public Node ReverseUsingPostOrderRecursion(Node head)
        {
            // Base case
            if (head == null || head.Next == null)
                return head;

            // Recursively reverse the smaller list
            Node newHead = ReverseUsingPostOrderRecursion(head.Next);

            // Reverse the current node
            head.Next.Next = head;
            head.Next = null;

            return newHead;
        }
    }
}
