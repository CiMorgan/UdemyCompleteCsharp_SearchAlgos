using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9, -3, 5, 2, 6, -8, -6, 1, 3 };
            quickSort(arr, 0, arr.Length-1);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("Done");
        }
        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            
            while (true)
            {
                while(arr[left] < pivot)
                {
                    left++;
                }
                while(arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if(arr[left] == arr[right])
                    {
                        return right;
                    }

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }

            }
        }

        static int[] quickSort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int pivot = Partition(arr, left, right);
                if(pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
            return arr;
        }

    }
}
