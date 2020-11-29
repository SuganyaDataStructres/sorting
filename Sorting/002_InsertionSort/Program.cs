using System;

namespace _002_InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 10, 9, 1, 5, 6 };
            InsertionSort(arr);
            print_arr(arr);
        }
        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int t = arr[i];
                int m = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (t < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        m--;
                    }
                }
                arr[m] = t;
                print_arr(arr);
                Console.WriteLine("sugu");
            }
        }
        static void print_arr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+", ");
            }
            Console.WriteLine();
        }
        
    }
}
