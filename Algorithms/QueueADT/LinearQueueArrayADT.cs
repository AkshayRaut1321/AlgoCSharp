using System;

namespace AlgoCSharp.Algorithms.QueueADT
{
    public class LinearQueueArrayADT<T>
    {
        public int Capacity { get; private set; }
        public int Front { get; private set; }
        public int Rear { get; private set; }
        public int Size { get; private set; }

        private T[] _queueArray;

        private bool _canResetIfEmpty;

        public LinearQueueArrayADT(int capacity, bool canResetIfEmpty = true)
        {
            Capacity = capacity;
            _queueArray = new T[Capacity];
            Front = Rear = -1;
            _canResetIfEmpty = canResetIfEmpty;
        }

        public bool IsEmpty()
        {
            return Front == Rear;
        }

        public bool IsFull()
        {
            return Rear == Capacity - 1;
        }

        public void Enqueue(T data)
        {
            if (IsFull())
                throw new InvalidOperationException("Queue is full");

            _queueArray[++Rear] = data;
            Size++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            var result = _queueArray[++Front];
            _queueArray[Front] = default(T);
            Size--;

            if (_canResetIfEmpty && IsEmpty())
                Front = Rear = 1;

            return result;
        }

        public void Display()
        {
            Console.WriteLine("Queue items are:");
            for (int i = Front + 1; i <= Rear; i++)
            {
                Console.WriteLine(_queueArray[i]);
            }
        }
    }
}
