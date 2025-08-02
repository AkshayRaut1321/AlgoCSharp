using System;

namespace AlgoCSharp.Algorithms.StackADT
{
    public class StackArrayADT<T>
    {
        public int Capacity { get; private set; }
        public int Top { get; private set; }
        private T[] _stackArray;

        public StackArrayADT(int capacity)
        {
            Capacity = capacity;
            _stackArray = new T[Capacity];
            Top = -1;
        }

        public bool IsEmpty
        {
            get
            {
                return Top == -1;
            }
        }

        public bool IsFull
        {
            get
            {
                return Top + 1 == Capacity;
            }
        }

        public int Size
        {
            get
            {
                return Top + 1;
            }
        }

        public T StackTop
        {
            get
            {
                if (Top == -1)
                    return default(T);

                return _stackArray[Top];
            }
        }

        public void Push(T data)
        {
            if (IsFull)
                throw new ApplicationException("Stack overflow");

            _stackArray[++Top] = data;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new ApplicationException("Stack underflow");

            return _stackArray[Top--];
        }

        public T PeekAt(int position)
        {
            if (IsEmpty)
                throw new ApplicationException("Stack underflow");

            return _stackArray[Top - position];
        }

        public void Display()
        {
            if (IsEmpty)
                return;

            for (int i = Top; i > -1; i--)
            {
                Console.WriteLine(_stackArray[i]);
            }
        }
    }
}
