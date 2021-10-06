using System;

namespace Selection_Sort
{
    class Program
    {
        static int[] selectionSort(int[] arr)
        {
            int len = arr.Length;
            for(int i=0; i<len; i++)
            {
                int minIndex = i;
                for(int j=i; j<len; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;

            }
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 7, 1, 3, 8, 11 };
            selectionSort(arr);
        }
    }
}
