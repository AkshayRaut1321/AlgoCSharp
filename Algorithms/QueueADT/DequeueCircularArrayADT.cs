using System;

namespace AlgoCSharp.Algorithms.QueueADT
{
    public class DequeueCircularArrayADT<T>
    {
        private T[] _array;
        private int Capacity;
        private int Front;
        private int Rear;

        public DequeueCircularArrayADT(int capacity)
        {
            Capacity = capacity;
            _array = new T[Capacity];
            Front = -1;
            Rear = -1;
        }

        public bool IsEmpty()
        {
            return Front == -1;
        }

        public bool IsFull()
        {
            return (Front == 0 && Rear == Capacity - 1) || (Front == Rear + 1);
        }

        public void EnqueueAtRear(T data)
        {
            if (IsFull())
                throw new ApplicationException("DEQueue is full");

            if (IsEmpty())
            {
                Front = Rear = 0;
            }
            else
            {
                Rear = (Rear + 1) % Capacity;
            }

            _array[Rear] = data;
        }

        public void EnqueueAtFront(T data)
        {
            if (IsFull())
                throw new ApplicationException("DEQueue is full");

            if (IsEmpty())
            {
                Front = Rear = 0;
            }
            else
            {
                Front = (Front - 1 + Capacity) % Capacity;
            }

            _array[Front] = data;
        }

        public T DequeueAtFront()
        {
            if (IsEmpty())
                throw new ApplicationException("DEQueue is empty");

            T value = _array[Front];

            if (Front == Rear) // Only one element
            {
                Front = Rear = -1;
            }
            else
            {
                Front = (Front + 1) % Capacity;
            }

            return value;
        }

        public T DequeueAtRear()
        {
            if (IsEmpty())
                throw new ApplicationException("DEQueue is empty");

            T value = _array[Rear];

            if (Front == Rear) // Only one element
            {
                Front = Rear = -1;
            }
            else
            {
                Rear = (Rear - 1 + Capacity) % Capacity;
            }

            return value;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("DEQueue is empty");
                return;
            }

            Console.Write("DEQueue items: ");
            int i = Front;
            while (true)
            {
                Console.Write(_array[i] + " ");
                if (i == Rear) break;
                i = (i + 1) % Capacity;
            }
            Console.WriteLine();
        }
    }
}
