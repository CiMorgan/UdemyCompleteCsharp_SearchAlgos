using System;

namespace QuickSort
{
    class Program
    {
        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while(true)
            {
                while(arr[left] < pivot)
                {
                    left++;
                }
                while(arr[right] > pivot)
                {
                    right--;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
