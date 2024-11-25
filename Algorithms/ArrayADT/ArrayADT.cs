using System;

namespace AlgoCSharp.Algorithms.ArrayADT
{
    public class ArrayADT
    {
        int[] array;
        int length;

        public void Start()
        {
            Console.WriteLine("Enter the size of the array");
            array = new int[Convert.ToInt32(Console.ReadLine())];

            Console.WriteLine("Enter the number of numbers you want to save");
            var numbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements one by one");
            for (int i = 0; i < numbers; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                length++;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }

        public void Append(int newItem)
        {
            if (length == array.Length)
            {
                Console.WriteLine("Array is full");
                return;
            }
            array[length] = newItem;
            length++;
        }

        public void Insert(int newItem, int insertAt)
        {
            if (length == array.Length)
            {
                Console.WriteLine("Array is full");
                return;
            }

            if (insertAt < 0 || insertAt > array.Length - 1)
            {
                Console.WriteLine("Index is out of bound");
                return;
            }

            for (int i = length; i > insertAt; i--)
            {
                array[i] = array[i - 1];
            }

            array[insertAt] = newItem;
            length++;
        }
    }
}
