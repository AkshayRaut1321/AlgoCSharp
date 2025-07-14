using System;
using System.Collections.Generic;

namespace AlgoCSharp.Algorithms.LinkedList
{
    public class CircularLinkedListProgram
    {
        public SinglyLinkedList Head { get; set; }

        public int Count { get; internal set; }

        public void DisplayUsingLoop(SinglyLinkedList startNode)
        {
            do
            {
                Console.WriteLine(startNode.Value);
                startNode = startNode.Next;
            }
            while (startNode != Head);
        }

        static int flag = 0;
        public void DisplayRecursively(SinglyLinkedList node)
        {
            if (node != Head || flag == 0)
            {
                flag = 1;
                Console.WriteLine(node.Value);
                DisplayRecursively(node.Next);
            }
        }

        public void InsertAt(int position, int data, bool preventLoop = true)
        {
            SinglyLinkedList traverseNode = Head;
            SinglyLinkedList newNode = new SinglyLinkedList(data);
            newNode.Value = data;

            if (position < 0 || position > Count)
                return;

            if (position == 0)
            {
                if (Head == null)
                {
                    Head = newNode;
                    newNode.Next = newNode;
                }
                else
                {
                    while (traverseNode.Next != Head)
                    {
                        traverseNode = traverseNode.Next;
                    }
                    traverseNode.Next = newNode;
                    newNode.Next = Head;
                    Head = newNode;
                }
            }
            else if (position > 0)
            {
                for (int iterator = 0; iterator < position - 1 && traverseNode != null; iterator++)
                {
                    traverseNode = traverseNode.Next;
                }
                if (traverseNode != null)
                {
                    newNode.Next = traverseNode.Next;
                    traverseNode.Next = newNode;
                }
            }
            Count++;
        }

        public SinglyLinkedList LinearSearch(SinglyLinkedList head, int key)
        {
            if (head == null || head.Value == key)
                return head;

            SinglyLinkedList current = head.Next;
            while (current != null)
            {
                if (current.Value == key)
                    return current;
                current = current.Next;
            }
            return null;
        }

        public SinglyLinkedList LinearSearchTransposition(SinglyLinkedList head, int key)
        {
            if (head == null || head.Value == key)
                return head;

            SinglyLinkedList previous = head;
            SinglyLinkedList current = previous.Next;

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

        public SinglyLinkedList LinearSearchMoveToFirst(SinglyLinkedList head, int key)
        {
            if (head == null || head.Value == key)
                return head;

            SinglyLinkedList headCopy = head;
            SinglyLinkedList previous = head;
            SinglyLinkedList current = head.Next;

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

        public void InsertLast(int data)
        {
            SinglyLinkedList newNode = new SinglyLinkedList(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                //TODO
            }
            Count++;
        }

        public void InsertSorted(int data)
        {
            SinglyLinkedList newNode = new SinglyLinkedList(data);

            SinglyLinkedList traverseNode = Head;
            SinglyLinkedList previousNode = null;

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
            SinglyLinkedList previousNode = Head;
            SinglyLinkedList traverseNode = Head.Next;

            if (Head.Value == data)
            {
                Head = Head.Next;
                return;
            }

            while (traverseNode != null)
            {
                if (traverseNode.Value == data)
                {
                    previousNode.Next = traverseNode.Next;
                    if (previousNode.Next == null)
                        //TODO
                        break;
                }
                previousNode = traverseNode;
                traverseNode = traverseNode.Next;
            }
            Count--;
        }

        public void RemoveDuplicatesFromSorted()
        {
            SinglyLinkedList previousNode = Head;
            SinglyLinkedList traverseNode = Head.Next;

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
            SinglyLinkedList traverseNode = Head;
            int i = 0;
            int[] array = new int[Count];

            while (traverseNode != null)
            {
                array[i] = traverseNode.Value;
                traverseNode = traverseNode.Next;
                i++;
            }

            traverseNode = Head;
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
            SinglyLinkedList previous = null;

            // current will point to the node being processed
            SinglyLinkedList current = null;

            // next starts at the head of the list
            SinglyLinkedList next = Head;

            // Traverse the list and reverse the links one by one
            while (next != null)
            {
                previous = current;        // Move previous one step forward
                current = next;            // Move current to the node to process
                next = next.Next;          // Advance next before breaking the link

                current.Next = previous;   // Reverse the current node's link
            }

            // Finally, set the head (First) to the new front of the list
            Head = current;
        }

        public void ReverseUsingTailRecursion(SinglyLinkedList previous, SinglyLinkedList next)
        {
            if (next != null)
            {
                ReverseUsingTailRecursion(next, next.Next);
                next.Next = previous;
            }
            else
            {
                Head = previous;
            }
        }

        public SinglyLinkedList ReverseUsingPostOrderRecursion(SinglyLinkedList head)
        {
            // Base case
            if (head == null || head.Next == null)
                return head;

            // Recursively reverse the smaller list
            SinglyLinkedList newHead = ReverseUsingPostOrderRecursion(head.Next);

            // Reverse the current node
            head.Next.Next = head;
            head.Next = null;

            return newHead;
        }

        public void CauseLoop()
        {
            Head.Next.Next.Next.Next = Head.Next.Next.Next;
        }

        public bool HasLoopUsingMemoization()
        {
            HashSet<int> ints = new HashSet<int>();
            SinglyLinkedList traverseNode = Head;
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
            SinglyLinkedList tortoise = Head;
            SinglyLinkedList hare = Head;
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
