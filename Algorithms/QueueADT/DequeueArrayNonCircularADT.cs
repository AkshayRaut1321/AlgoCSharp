using System;

namespace AlgoCSharp.Algorithms.QueueADT
{
    public class DequeueArrayNonCircularADT<T>
    {
        public int Capacity { get; private set; }
        public int Front { get; private set; }
        public int Rear { get; private set; }
        public int Size { get; private set; }

        private T[] _queueArray;

        public DequeueArrayNonCircularADT(int capacity)
        {
            Capacity = capacity;
            _queueArray = new T[Capacity];
            Front = Rear = -1;
        }

        public bool IsEmpty()
        {
            return Rear == Front;
        }

        public bool IsFull()
        {
            return Rear == Capacity - 1;
        }

        public void EnqueueAtRear(T data)
        {
            if (IsFull())
            {
                throw new ApplicationException("DEQueue is full");
            }
            _queueArray[++Rear] = data;
            Size++;
        }
        public void EnqueueAtFront(T data)
        {
            if (IsFull())
            {
                throw new ApplicationException("DEQueue is full");
            }
            _queueArray[Front--] = data;
            Size++;
        }

        public T DequeueAtRear()
        {
            if (IsEmpty())
            {
                throw new ApplicationException("DEQueue is empty");
            }
            var result = _queueArray[Rear];
            _queueArray[Rear] = default(T);
            Size--;
            Rear--;
            return result;
        }

        public T DequeueAtFront()
        {
            if (IsEmpty())
            {
                throw new ApplicationException("DEQueue is empty");
            }
            var result = _queueArray[++Front];
            _queueArray[Front] = default(T);
            Size--;
            return result;
        }

        public void Display()
        {
            Console.WriteLine("DEQueue items are:");
            for (int i = Front + 1; i <= Rear; i++)
            {
                Console.WriteLine(_queueArray[i]);
            }
        }
    }
}
