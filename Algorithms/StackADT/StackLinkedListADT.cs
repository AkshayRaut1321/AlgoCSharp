using AlgoCSharp.Algorithms.LinkedList;
using System;

namespace AlgoCSharp.Algorithms.StackADT
{
    public class StackLinkedListADT
    {
        public int Capacity { get; private set; }
        public int Top { get; private set; }
        private SinglyLinkedListNode Head;

        public StackLinkedListADT(int capacity)
        {
            Capacity = capacity;
            Top = -1;
        }

        public bool IsEmpty
        {
            get
            {
                return Top == -1;
            }
        }

        public bool IsFull
        {
            get
            {
                return Top + 1 == Capacity;
            }
        }

        public int Size
        {
            get
            {
                return Top + 1;
            }
        }

        public int StackTop
        {
            get
            {
                if (Top == -1)
                    return -1;

                return Head.Value;
            }
        }

        public void Push(int data)
        {
            if (IsFull)
                throw new ApplicationException("Stack overflow");

            var newHeadNode = new SinglyLinkedListNode(data);
            newHeadNode.Next = Head;
            Head = newHeadNode;
            Top++;
        }

        public int Pop()
        {
            if (IsEmpty)
                throw new ApplicationException("Stack underflow");

            var popElement = Head;
            Top--;
            Head = Head.Next;

            return popElement.Value;
        }

        public int PeekAt(int position)
        {
            if (IsEmpty)
                throw new ApplicationException("Stack underflow");

            SinglyLinkedListNode traverseNode = Head;
            for (int i = 0; i < position && traverseNode != null; i++)
            {
                traverseNode = traverseNode.Next;
            }

            if (traverseNode != null)
                return traverseNode.Value;

            return -1;
        }

        public void Display()
        {
            if (IsEmpty)
                return;

            SinglyLinkedListNode traverseNode = Head;
            while (traverseNode != null)
            {
                Console.WriteLine(traverseNode.Value);
                traverseNode = traverseNode.Next;
            }
        }
    }
}
