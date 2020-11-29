using System;

namespace _005_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 7, 6, 1, 0, 9, 2 };
            int n1 = 0;
            int n2 = arr.Length - 1;
            QuickSort(arr, n1, n2);
        }
        static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void QuickSort(int[] arr, int n1, int n2)
        {
            Console.WriteLine($"n1={n1}, n2={n2}");
            print(arr);

            int m;
            if (n1 < n2)
            {
                m = Pivot(arr, n1, n2);
                QuickSort(arr, n1, m - 1);
                QuickSort(arr, m + 1, n2);
            }
        }
        static int Pivot(int[] arr, int n1, int n2)
        {
            int p = n1;
            int m;
            while (true)
            {
                if (n1 >= n2)
                {
                    int c = arr[p];
                    arr[p] = arr[n2];
                    arr[n2] = c;
                    m = n2;
                    break;
                }
                while ((arr[n1] <= arr[p]) && n1 < n2)
                {
                    n1++;
                }
                while ((arr[n2] >= arr[p]) && n2 > n1)
                {
                    n2--;
                }
                if (arr[n1] > arr[p] && arr[n2] < arr[p])
                {
                    int k = arr[n1];
                    arr[n1] = arr[n2];
                    arr[n2] = k;
                    n1++;
                    n2--;
                }
            }
            return m;
        }
    }
}
