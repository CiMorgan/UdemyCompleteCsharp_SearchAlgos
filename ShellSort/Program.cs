using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOrg = new int[] { 4, 8, -1, 0, 2, 7, 11, 6 };
            shellSort(arrOrg);


        }

        //static int[] shellSort(int[] arr)
        //{
        //    int length = arr.Length;
        //    int gap = length/2;
        //    int temp, i, j;
        //    while (gap > 0)
        //    {
        //        for (i=gap; i<length; i++)
        //        {
        //            temp = arr[i];
        //            j=i;
        //            while(j >= gap && arr[j-gap]>temp)
        //            {
        //                arr[j] = arr[j - gap];
        //                j = j - gap;
        //            }
        //            arr[j] = temp;
        //        }
        //        gap = gap / 2;
        //    }
        //    foreach (int a in arr)
        //    {
        //        Console.Write(a + " ");
        //    }
        //    return arr;
        //}

        static int[] shellSort(int[] arr)
        {
            int length = arr.Length;
 
            for (int gap = length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < length; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j=i;  j >= gap && arr[j - gap] > temp; j-=gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
            return arr;
        }
    }
}
