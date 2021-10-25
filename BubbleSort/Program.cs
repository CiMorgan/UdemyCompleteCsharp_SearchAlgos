using System;

namespace BubbleSort
{
    class Program
    {

        static int[] bubbleSort(int[] arr)
        {
            int len = arr.Length;
            for (int i=len-1; i>=0; i--)
            {
                for (int j=1; j<=i; j++)
                {
                    if (arr[j-1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;

        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 1, 6, 4, 9, 12, 5, 11 };
            int[] b = bubbleSort(a);
            foreach (int x in b)
            {
                Console.WriteLine(x);
            }
        }
    }
}
