using System;

namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            PrintArray(array);
            Console.WriteLine("Array after reverse");
            ReverseArray(array);
            PrintArray(array);
        }

        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public static void ReverseArray(int[] array)
        {
            int end = array.Length - 1;
            int start = 0;
            int temp;
            while(start < end)
            {
                temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }
    }
}
