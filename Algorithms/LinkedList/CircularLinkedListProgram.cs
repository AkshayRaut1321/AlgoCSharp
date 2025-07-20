using System;
using System.Collections.Generic;

namespace AlgoCSharp.Algorithms.LinkedList
{
    public class CircularLinkedListProgram
    {
        public SinglyLinkedListNode Head { get; set; }

        public int Count { get; internal set; }

        public void DisplayUsingLoop(SinglyLinkedListNode startNode)
        {
            do
            {
                Console.WriteLine(startNode.Value);
                startNode = startNode.Next;
            }
            while (startNode != Head);
        }

        static int flag = 0;
        public void DisplayRecursively(SinglyLinkedListNode node)
        {
            if (node != Head || flag == 0)
            {
                flag = 1;
                Console.WriteLine(node.Value);
                DisplayRecursively(node.Next);
            }
        }

        public void InsertAt(int position, int data)
        {
            SinglyLinkedListNode traverseNode = Head;
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

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

        public void DeleteAt(int position)
        {
            if (position < 0 || position >= Count)
                return;

            SinglyLinkedListNode traverseNode = Head;
            SinglyLinkedListNode nextNode = null;

            if (position == 0)
            {
                while (traverseNode.Next != Head)
                    traverseNode = traverseNode.Next;
                if (traverseNode == Head)
                {
                    Head = null;
                }
                else
                {
                    traverseNode.Next = Head.Next;
                    Head = traverseNode.Next;
                }
            }
            else
            {
                for (int i = -1; i < position - 2; i++)
                {
                    traverseNode = traverseNode.Next;
                }
                nextNode = traverseNode.Next;
                traverseNode.Next = nextNode.Next;
            }
            Count--;
        }

        public bool HasLoopUsingMemoization()
        {
            HashSet<int> ints = new HashSet<int>();
            SinglyLinkedListNode traverseNode = Head;
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
            SinglyLinkedListNode tortoise = Head;
            SinglyLinkedListNode hare = Head;
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
