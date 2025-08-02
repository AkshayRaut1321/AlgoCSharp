using System;
using System.Collections.Generic;

namespace AlgoCSharp.Algorithms.LinkedList
{
    public class SinglyLinkedListProgram
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

        public void InsertAt(int position, int data)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            if (position == 0)
            {
                newNode.Next = First;
                First = newNode;
            }
            else if (position > 0)
            {
                SinglyLinkedListNode iteratorNode = First;
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

        public SinglyLinkedListNode GetMiddleNodeBruteForce()
        {
            int count = 0;
            SinglyLinkedListNode traverseNode = First;
            while (traverseNode != null)
            {
                traverseNode = traverseNode.Next;
                count++;
            }
            traverseNode = First;
            for (int i = 0; i < ((count + 1) / 2) && traverseNode != null; i++)
            {
                traverseNode = traverseNode.Next;
            }
            return traverseNode;
        }

        public SinglyLinkedListNode GetMiddleNodeTortoiseHare()
        {
            SinglyLinkedListNode tortoise = First;
            SinglyLinkedListNode hare = First;
            while (hare != null)
            {
                hare = hare.Next;
                if (hare != null)
                {
                    hare = hare.Next;
                    if (hare != null)
                    {
                        tortoise = tortoise.Next;
                    }
                }
            }
            return tortoise;
        }

        public SinglyLinkedListNode FindIntersectingNodeDictionary(SinglyLinkedListNode headA, SinglyLinkedListNode headB)
        {
            HashSet<SinglyLinkedListNode> uniqueNodes = new HashSet<SinglyLinkedListNode>();

            while (headA != null)
            {
                headA = headA.Next;
                uniqueNodes.Add(headA);
            }

            while (headB != null)
            {
                if (uniqueNodes.Contains(headB))
                    return headB;

                headB = headB.Next;
            }
            return null;
        }

        private int GetLength(SinglyLinkedListNode head)
        {
            int length = 0;
            while (head != null)
            {
                length++;
                head = head.Next;
            }
            return length;
        }

        public SinglyLinkedListNode FindIntersectingNodeLengthAlignment(SinglyLinkedListNode headA, SinglyLinkedListNode headB)
        {
            int lenA = GetLength(headA);
            int lenB = GetLength(headB);

            // Advance the longer list by the length difference
            while (lenA > lenB)
            {
                headA = headA.Next;
                lenA--;
            }
            while (lenB > lenA)
            {
                headB = headB.Next;
                lenB--;
            }

            // Now both pointers are the same distance from the end
            while (headA != null && headB != null)
            {
                if (headA == headB)
                    return headA; // Found the intersection

                headA = headA.Next;
                headB = headB.Next;
            }

            return null; // No intersection
        }

        public SinglyLinkedListNode FindIntersectingNodeTortoiseSwitchPath(SinglyLinkedListNode headA, SinglyLinkedListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            SinglyLinkedListNode p1 = headA;
            SinglyLinkedListNode p2 = headB;

            // After at most 2 passes each, they will either meet or both be null
            while (p1 != p2)
            {
                p1 = (p1 == null) ? headB : p1.Next;
                p2 = (p2 == null) ? headA : p2.Next;
            }

            // Either both are null (no intersection) or at the intersection node
            return p1;
        }

        public SinglyLinkedListNode GetIntersectionNode(SinglyLinkedListNode headA, SinglyLinkedListNode headB)
        {
            for (SinglyLinkedListNode a = headA; a != null; a = a.Next)
            {
                for (SinglyLinkedListNode b = headB; b != null; b = b.Next)
                {
                    if (a == b)
                        return a; // Found intersection
                }
            }

            return null; // No intersection
        }

        public void Display()
        {
            SinglyLinkedListNode traverseNode = First;
            while (traverseNode != null)
            {
                Console.WriteLine(traverseNode.Value);
            }
        }
    }
}
