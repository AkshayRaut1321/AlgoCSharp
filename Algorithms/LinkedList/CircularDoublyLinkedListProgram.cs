using System;

namespace AlgoCSharp.Algorithms.LinkedList
{
    public class CircularDoublyLinkedListProgram
    {
        public CircularDoublyLinkedList Head { get; set; }

        public int Count { get; internal set; }

        public void InsertAt(int position, int data)
        {
            Console.WriteLine("Inserting");
            CircularDoublyLinkedList newNode = new CircularDoublyLinkedList(data);

            if (position < 0 || position >= Count)
                return;

            if (position == 0)
            {
                if (Head == null)
                {
                    Head = newNode;
                    newNode.Next = newNode;
                    newNode.Previous = newNode;
                }
                else
                {
                    newNode.Next = Head;
                    newNode.Previous = Head.Previous;
                    Head.Previous.Next = newNode;
                    Head.Previous = newNode;
                    Head = newNode;
                }
            }
            else
            {
                CircularDoublyLinkedList traverseNode = Head;
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
            if (position < 0 || position >= Count || Head == null)
                return;

            CircularDoublyLinkedList traverseNode = Head;

            if (position == 0)
            {
                Head.Next.Previous = Head.Previous;
                Head.Previous.Next = Head.Next;
                Head = Head.Next;
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
            CircularDoublyLinkedList traverseNode = Head;
            do
            {
                Console.WriteLine(traverseNode.Value);
                traverseNode = traverseNode.Next;
            } while (traverseNode != Head && traverseNode != null);
        }

        public void Reverse()
        {
            Console.WriteLine("Reversing");
            CircularDoublyLinkedList traverseNode = Head;
            while (traverseNode != null)
            {
                var temp = traverseNode.Next;
                traverseNode.Next = traverseNode.Previous;
                traverseNode.Previous = temp;
                traverseNode = traverseNode.Previous;

                if (traverseNode != null && traverseNode.Next == null)
                {
                    Head = traverseNode;
                }
            }
        }
    }
}
