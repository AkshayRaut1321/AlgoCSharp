using System;
using System.Collections.Generic;

namespace AlgoCSharp.Algorithms.QueueADT
{
    public class PriorityQueueUnsortedArrayADT
    {
        private List<(int value, int priority)> _queue = new List<(int, int)>();
        private int _capacity;

        public PriorityQueueUnsortedArrayADT(int capacity)
        {
            _capacity = capacity;
        }

        public bool IsEmpty() => _queue.Count == 0;
        public bool IsFull() => _queue.Count >= _capacity;

        public void Enqueue(int value, int priority)
        {
            if (IsFull()) throw new InvalidOperationException("Queue is full");
            _queue.Add((value, priority));
        }

        public int Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty");

            int maxIndex = 0;
            for (int i = 1; i < _queue.Count; i++)
            {
                if (_queue[i].priority > _queue[maxIndex].priority)
                    maxIndex = i;
            }

            int result = _queue[maxIndex].value;
            _queue.RemoveAt(maxIndex);
            return result;
        }

        public void Display()
        {
            Console.WriteLine("Unsorted PQ:");
            foreach (var item in _queue)
                Console.WriteLine($"Value={item.value}, Priority={item.priority}");
        }
    }
}
