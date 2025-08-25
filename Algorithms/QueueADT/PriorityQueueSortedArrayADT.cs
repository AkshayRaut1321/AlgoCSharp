using System;
using System.Collections.Generic;

namespace AlgoCSharp.Algorithms.QueueADT
{
    public class PriorityQueueSortedArrayADT
    {
        private List<(int value, int priority)> _queue = new List<(int, int)>();
        private int _capacity;

        public PriorityQueueSortedArrayADT(int capacity)
        {
            _capacity = capacity;
        }

        public bool IsEmpty() => _queue.Count == 0;
        public bool IsFull() => _queue.Count >= _capacity;

        public void Enqueue(int value, int priority)
        {
            if (IsFull()) throw new InvalidOperationException("Queue is full");

            int i = 0;
            while (i < _queue.Count && _queue[i].priority >= priority)
                i++;

            _queue.Insert(i, (value, priority));
        }

        public int Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty");
            int result = _queue[0].value;
            _queue.RemoveAt(0);
            return result;
        }

        public void Display()
        {
            Console.WriteLine("Sorted PQ:");
            foreach (var item in _queue)
                Console.WriteLine($"Value={item.value}, Priority={item.priority}");
        }
    }
}
