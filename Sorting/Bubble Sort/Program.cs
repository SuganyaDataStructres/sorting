using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6 };
            BubbleSort(arr);
            print(arr);
        }
        static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+", ");
            }
            Console.WriteLine();
        }
        static void BubbleSort(int[] arr)
        {
            for (int i = 1; i <arr.Length; i++)
            {
                print(arr);
                for (int j = 0; j < arr.Length-i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
        }
    }
}
