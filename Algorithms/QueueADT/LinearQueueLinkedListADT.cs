using AlgoCSharp.Algorithms.LinkedList;
using System;

namespace AlgoCSharp.Algorithms.QueueADT
{
    public class LinearQueueLinkedListADT
    {
        private SinglyLinkedListProgram list = new SinglyLinkedListProgram();

        // Enqueue → Insert at the end
        public void Enqueue(int data)
        {
            list.InsertLast(data);
            Console.WriteLine($"{data} enqueued");
        }

        // Dequeue → Remove from the front
        public int Dequeue()
        {
            if (list.First == null)
                throw new InvalidOperationException("Queue is empty");

            int value = list.First.Value;
            list.First = list.First.Next;
            list.Count--;

            Console.WriteLine($"{value} dequeued");
            return value;
        }

        // Peek → Just check front value
        public int Peek()
        {
            if (list.First == null)
                throw new InvalidOperationException("Queue is empty");

            return list.First.Value;
        }

        // Count
        public int Count => list.Count;

        // Print Queue
        public void PrintQueue()
        {
            Console.Write("Queue: ");
            SinglyLinkedListNode current = list.First;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}