using System;

namespace _006_ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 6, 8, 9, 3, 2, 10, 5, 1 };
            int h = arr.Length;
            ShellSort(arr, h / 2);
            print(arr);
        }
        static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
        static void ShellSort(int[] arr, int h)
        {
            Console.WriteLine("shell sort h = " + h);
            print(arr);
            if (h >= 1)
            {
                for (int k = 0; k <= h; k++)
                {
                    for (int i = k + h; i < arr.Length; i = i + h)
                    {
                        int t = arr[i];
                        int m = i;
                        for (int j = i - h; j >= 0; j = j - h)
                        {
                            if (t < arr[j])
                            {
                                arr[j + h] = arr[j];
                                m = m - h;
                            }
                        }
                        arr[m] = t;
                    }
                }
                ShellSort(arr, h / 2);
            }

        }

        static void ShellSort2(int[] arr, int h)
        {
            if (h >= 1)
            {
                for (int k = 0; k < h; k++)
                {
                    for (int i = k; i < arr.Length; i += h)
                    {
                        int t = arr[i];
                        int m = i;
                        for (int j = i - h; j >= 0; j = j - h)
                        {
                            if (t < arr[j])
                            {
                                arr[j + h] = arr[j];
                                m = m - h;
                            }
                        }
                        arr[m] = t;
                    }
                }
                ShellSort2(arr, h / 2);
            }
        }
    }
}
