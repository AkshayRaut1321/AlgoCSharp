using System;
using System.Collections.Generic;

namespace AlgoCSharp.Algorithms.LinkedList
{
    public class DoublyLinkedListProgram
    {
        public DoublyLinkedListNode First { get; set; }
        public DoublyLinkedListNode Last { get; set; }

        public int Count { get; internal set; }

        public void InsertAt(int position, int data)
        {
            Console.WriteLine("Inserting");
            DoublyLinkedListNode newNode = new DoublyLinkedListNode(data);

            if (position < 0 || position > Count)
                return;

            if (position == 0)
            {
                newNode.Next = First;
                First.Previous = newNode;
                First = newNode;
            }
            else
            {
                DoublyLinkedListNode traverseNode = First;
                for (int i = 0; i < position - 1 && traverseNode != null; i++)
                {
                    traverseNode = traverseNode.Next;
                }
                if (traverseNode != null)
                {
                    //Order of execution is important.
                    newNode.Next = traverseNode.Next;
                    newNode.Previous = traverseNode;
                    if (traverseNode.Next != null)
                    {
                        traverseNode.Next.Previous = newNode;
                    }
                    traverseNode.Next = newNode;
                }
            }
            Count++;
        }

        public void DeleteAt(int position)
        {
            Console.WriteLine("Deleting");
            if (position < 0 || position >= Count)
                return;

            DoublyLinkedListNode traverseNode = First;

            if (position == 0)
            {
                First = First.Next;
                if (First != null)
                    First.Previous = null;
            }
            else
            {
                for (int i = 0; i < position && traverseNode != null; i++)
                {
                    traverseNode = traverseNode.Next;
                }
                if (traverseNode != null)
                {
                    traverseNode.Previous.Next = traverseNode.Next;
                    if (traverseNode.Next != null)
                    {
                        traverseNode.Next.Previous = traverseNode.Previous;
                    }
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Displaying");
            DoublyLinkedListNode traverseNode = First;
            while (traverseNode != null)
            {
                Console.WriteLine(traverseNode.Value);
                traverseNode = traverseNode.Next;
            }
        }

        public void Reverse()
        {
            Console.WriteLine("Reversing");
            DoublyLinkedListNode traverseNode = First;
            while (traverseNode != null)
            {
                var temp = traverseNode.Next;
                traverseNode.Next = traverseNode.Previous;
                traverseNode.Previous = temp;
                traverseNode = traverseNode.Previous;

                if (traverseNode != null && traverseNode.Next == null)
                {
                    First = traverseNode;
                }
            }
        }
    }
}
