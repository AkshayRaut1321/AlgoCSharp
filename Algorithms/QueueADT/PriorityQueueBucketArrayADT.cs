using System;
using System.Collections.Generic;

namespace AlgoCSharp.Algorithms.QueueADT
{
    public class PriorityQueueBucketArrayADT
    {
        Dictionary<int, int[]> _priorityArrays = new Dictionary<int, int[]>();
        Dictionary<int, int> _front = new Dictionary<int, int>();
        Dictionary<int, int> _rear = new Dictionary<int, int>();
        int Capacity;
        int Priority;

        public PriorityQueueBucketArrayADT(int capacity, int numberOfPriorities)
        {
            Capacity = capacity;
            Priority = numberOfPriorities;

            _priorityArrays = new Dictionary<int, int[]>(numberOfPriorities);
            for (int i = 0; i < numberOfPriorities; i++)
            {
                _priorityArrays[i] = new int[capacity];
            }
            _front = new Dictionary<int, int>(numberOfPriorities);
            for (int i = 0; i < numberOfPriorities; i++)
            {
                _front[i] = -1;
            }
            _rear = new Dictionary<int, int>(numberOfPriorities);
            for (int i = 0; i < numberOfPriorities; i++)
            {
                _rear[i] = -1;
            }
        }

        public bool IsEmpty(int priority)
        {
            return _front[priority] == _rear[priority];
        }

        public bool IsFull(int priority)
        {
            return _rear[priority] == Capacity - 1;
        }

        public void Enqueue(int data, int priority)
        {
            if (IsFull(priority))
                throw new InvalidOperationException("Queue is full");

            _priorityArrays[priority][++_rear[priority]] = data;
        }

        public int Dequeue()
        {
            int priorityForDequeue = 0;
            for (; priorityForDequeue < Priority; priorityForDequeue++)
            {
                if (!IsEmpty(priorityForDequeue))
                {
                    break;
                }
            }

            if (priorityForDequeue == Priority)
                throw new InvalidOperationException("Queue is empty");

            var result = _priorityArrays[priorityForDequeue][++_front[priorityForDequeue]];
            _priorityArrays[priorityForDequeue][_front[priorityForDequeue]] = 0;
            return result;
        }
    }
}
