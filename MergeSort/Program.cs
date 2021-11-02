using System;

namespace MergeSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 9, -3, 5, 2, 6, -8, -6, 1, 3 };
            int[] x = mergeSort(arr);
            foreach (int i in x)
            {
                Console.Write(i + " ");
            }
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
            for (int j=midPoint; j<array.Length; j++)
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
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            while(indexLeft<left.Length || indexRight < right.Length)
            {
                if(indexLeft < left.Length && indexRight < right.Length)
                {
                    if(left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if(indexLeft <left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }

            return result;

        }

    }
}
