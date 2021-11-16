using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 3, 1, 7, 4, 6, 0 };
            heapSort(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        static int[] heapSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n/2 -1; i>=0; i--)
            {
                heapify(arr, n, i);
            }
            for (int i = n-1; i>= 0; i--)
            {
                swap(arr, 0, i);
                heapify(arr, i, 0);
            }
            return arr;
        }

        static void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left<n && arr[left] > arr[largest])
            {
                largest = left;
            }
            if (right<n && arr[right] > arr[largest])
            {
                largest = right;
            }
            if(largest != i)
            {
                swap(arr, i, largest);
                heapify(arr, n, largest);
            }
        }
        
        static void swap(int[] arr, int element1, int element2)
        {
            int swap = arr[element1];
            arr[element1] = arr[element2];
            arr[element2] = swap;
        }
    }
}
