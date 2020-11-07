using System;

namespace _002_InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 10, 9, 1, 5, 6 };
            Insertion_Sort(arr);
            print_arr(arr);
        }
        static void print_arr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+", ");
            }
            Console.WriteLine();
        }
        static void Insertion_Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine($"i={i}");
                print_arr(arr);
                int m = arr[i];
                for (int j = i-1;j>=0;j--)
                {
                    if (m < arr[j])
                    {
                        arr[j+1] = arr[j];
                        if (j == 0)
                        {
                            arr[j] = m;
                        }
                    }
                    else
                    {
                        arr[j+1] = m;
                        break;
                    }
                }
            }
        }
    }
}
