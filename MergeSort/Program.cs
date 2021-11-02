using System;

namespace MergeSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];

            if(array.Length<=1)
            {
                return array;
            }
            int midPoint = array.Length / 2;
            left = new int[midPoint];
            if (array.Length%2==0)
            {
                right = new int[midPoint];
            }
            else
            {
                right = new int[midPoint + 1];
            }
            for (int i=0; i<midPoint; i++)
            {
                left[i] = array[i];
            }
            int x = 0;
            for (int j=midPoint; j<array.Length, j++)
            {
                right[x] = array[j];
                x++;
            }
            left = mergeSort(left);
            right = mergeSort(right);
            result = merge(left, right);
            return result;


        }
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            return result;

        }

    }
}
