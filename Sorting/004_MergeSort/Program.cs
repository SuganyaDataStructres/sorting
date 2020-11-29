using System;

namespace _004_MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
            int n1 = 0;
            int n2 = arr.Length - 1;
            SeperateSort(arr, n1, n2);
            print(arr, n1, n2);
        }
        static void SeperateSort(int[] arr, int n1, int n2)
        {
            print(arr, n1, n2);
            int m;
            if (n2 > n1)
            {
                m = (n1 + n2) / 2;
                SeperateSort(arr, n1, m);
                SeperateSort(arr, m + 1, n2);
                MergeTwoSubArray(arr, n1, n2);
            }
        }
        static void MergeTwoSubArray(int[] arr, int n1, int n2)
        {
            int m = (n1 + n2) / 2;
            int a = n1;
            int b = m + 1;
            int[] Arr = new int[n2 - n1 + 1];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (a > m)
                {
                    Arr[i] = arr[b];
                    b++;
                }
                else if (b > n2)
                {
                    Arr[i] = arr[a];
                    a++;
                }
                else if (arr[a] < arr[b])
                {
                    Arr[i] = arr[a];
                    a++;
                }
                else if (arr[a] > arr[b])
                {
                    Arr[i] = arr[b];
                    b++;
                }
            }
            int c = 0;
            for (int i = n1; i <= n2; i++)
            {
                arr[i] = Arr[c];
                c++;
            }
            print(arr, n1, n2);
            Console.WriteLine("sugu");
        }
        static void print(int[] arr, int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
