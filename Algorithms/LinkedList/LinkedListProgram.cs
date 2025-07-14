using System.Collections.Generic;

namespace AlgoCSharp.Algorithms.LinkedList
{
    public class LinkedListProgram
    {
        public SinglyLinkedListNode First { get; set; }
        public SinglyLinkedListNode Last { get; set; }

        public int Count { get; internal set; }

        public SinglyLinkedListNode LinearSearch(SinglyLinkedListNode head, int key)
        {
            if (head == null || head.Value == key)
                return head;

            SinglyLinkedListNode current = head.Next;
            while (current != null)
            {
                if (current.Value == key)
                    return current;
                current = current.Next;
            }
            return null;
        }

        public SinglyLinkedListNode LinearSearchTransposition(SinglyLinkedListNode head, int key)
        {
            if (head == null || head.Value == key)
                return head;

            SinglyLinkedListNode previous = head;
            SinglyLinkedListNode current = previous.Next;

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

        public SinglyLinkedListNode LinearSearchMoveToFirst(SinglyLinkedListNode head, int key)
        {
            if (head == null || head.Value == key)
                return head;

            SinglyLinkedListNode headCopy = head;
            SinglyLinkedListNode previous = head;
            SinglyLinkedListNode current = head.Next;

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

        public void InsertAt(SinglyLinkedListNode head, int position, int data)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            if (position == 0)
            {
                newNode.Value = data;
                head = newNode;
            }
            else if (position > 0)
            {
                SinglyLinkedListNode iteratorNode = head;
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
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

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
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            SinglyLinkedListNode traverseNode = First;
            SinglyLinkedListNode previousNode = null;

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
            SinglyLinkedListNode previousNode = First;
            SinglyLinkedListNode traverseNode = First.Next;

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
            SinglyLinkedListNode previousNode = First;
            SinglyLinkedListNode traverseNode = First.Next;

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
            SinglyLinkedListNode traverseNode = First;
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
            SinglyLinkedListNode previous = null;

            // current will point to the node being processed
            SinglyLinkedListNode current = null;

            // next starts at the head of the list
            SinglyLinkedListNode next = First;

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

        public void ReverseUsingTailRecursion(SinglyLinkedListNode previous, SinglyLinkedListNode next)
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

        public SinglyLinkedListNode ReverseUsingPostOrderRecursion(SinglyLinkedListNode head)
        {
            // Base case
            if (head == null || head.Next == null)
                return head;

            // Recursively reverse the smaller list
            SinglyLinkedListNode newHead = ReverseUsingPostOrderRecursion(head.Next);

            // Reverse the current node
            head.Next.Next = head;
            head.Next = null;

            return newHead;
        }

        public void CauseLoop()
        {
            First.Next.Next.Next.Next = First.Next.Next.Next;
        }

        public bool HasLoopUsingMemoization()
        {
            HashSet<int> ints = new HashSet<int>();
            SinglyLinkedListNode traverseNode = First;
            while (traverseNode != null)
            {
                if (ints.Contains(traverseNode.Value))
                    return true;

                ints.Add(traverseNode.Value);
                traverseNode = traverseNode.Next;
            }
            return false;
        }

        public bool HasLoopUsingSlidingWindow()
        {
            SinglyLinkedListNode tortoise = First;
            SinglyLinkedListNode hare = First;
            do
            {
                tortoise = tortoise.Next;
                hare = hare.Next;
                if (hare != null)
                    hare = hare.Next;
            }
            while (tortoise != null && hare != null && tortoise != hare);

            return tortoise == hare;
        }
    }
}
