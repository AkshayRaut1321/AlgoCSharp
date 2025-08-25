using System;

namespace AlgoCSharp.Algorithms.QueueADT
{
    public class CircularQueueArrayADT<T>
    {
        public int Capacity { get; private set; }
        public int Front { get; private set; }
        public int Rear { get; private set; }
        public int Size { get; private set; }

        private T[] _queueArray;

        public CircularQueueArrayADT(int capacity)
        {
            Capacity = capacity + 1;
            _queueArray = new T[Capacity];
            Front = Rear = 0;
        }

        public bool IsEmpty()
        {
            return Front == Rear;
        }

        public bool IsFull()
        {
            return ((Rear + 1) % Capacity) == Front;
        }

        public void Enqueue(T data)
        {
            if (IsFull())
                throw new InvalidOperationException("Queue is full");

            Rear = (Rear + 1) % Capacity;
            _queueArray[Rear] = data;
            Size++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            Front = (Front + 1) % Capacity;
            var result = _queueArray[Front];
            _queueArray[Front] = default(T);
            Size--;

            return result;
        }

        public void Display()
        {
            Console.WriteLine("Queue items are:");
            int i = (Front + 1) % Capacity;
            for (; i != ((Rear + 1) % Capacity);)
            {
                Console.WriteLine(_queueArray[i]);
                i = (i + 1) % Capacity;
            }
        }
    }
}
