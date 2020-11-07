using System;

namespace _001_SelectionSort
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 6, 1, 8, 4, 5 };
            selection_sort(arr);
            print_arr(arr);
        }
        static void print_arr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void swap(int[] arr, int i, int z)
        {
            int t = arr[i];
            arr[i] = arr[z];
            arr[z] = t;
        }
        static void selection_sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int z = find_index(arr, i);
                swap(arr, i, z);
            }
        }
        static int find_index(int[] arr, int i)
        {
            int m = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[m] > arr[j])
                {
                    m = j;
                }
            }
            return m;
        }
    }
}
