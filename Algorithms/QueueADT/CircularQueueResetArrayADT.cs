using System;

namespace AlgoCSharp.Algorithms.QueueADT
{
    public class CircularQueueResetArrayADT<T>
    {
        public int Capacity { get; private set; }
        public int Front { get; private set; }
        public int Rear { get; private set; }
        public int Size { get; private set; }

        private T[] _queueArray;

        public CircularQueueResetArrayADT(int capacity)
        {
            Capacity = capacity;
            _queueArray = new T[Capacity];
            Front = Rear = -1;
            Size = 0;
        }

        public bool IsEmpty()
        {
            return Front == -1;
        }

        public bool IsFull()
        {
            return ((Rear + 1) % Capacity) == Front;
        }

        public void Enqueue(T data)
        {
            if (IsFull())
                throw new InvalidOperationException("Queue is full");

            if (IsEmpty())
            {
                // inserting first element
                Front = Rear = 0;
            }
            else
            {
                Rear = (Rear + 1) % Capacity;
            }

            _queueArray[Rear] = data;
            Size++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            var result = _queueArray[Front];
            _queueArray[Front] = default(T);

            if (Front == Rear)
            {
                // last element removed → reset
                Front = Rear = -1;
            }
            else
            {
                Front = (Front + 1) % Capacity;
            }

            Size--;
            return result;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Console.WriteLine("Queue items are:");
            int i = Front;
            while (true)
            {
                Console.WriteLine(_queueArray[i]);
                if (i == Rear)
                    break;
                i = (i + 1) % Capacity;
            }
        }
    }
}
