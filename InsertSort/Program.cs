using System;

namespace InsertSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 12, -15, 0, 5, -2, 3, -5 };
            int[] x = insertionSort(arr);
            foreach (int i in x)
            {
                Console.Write(i + " ");
            }
        }
        static int[] insertionSort(int[] arr)
        {
            for (int i=0; i<arr.Length; i++)
            {
                int value = arr[i];
                for (int j = i-1; j>-1 && arr[j] > value; j--)
                {
                    arr[j + 1] = arr[j];
                    arr[j] = value;
                }
            }

            return arr;
        }
    }
}
