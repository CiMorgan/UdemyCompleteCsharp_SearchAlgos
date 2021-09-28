using System;

namespace InterpolationSearch
{
    public class Program
    {

        public int interpolationSearch(int[] arr, int length, int x)
        {
            int low = 0;
            int high = length - 1;
            while (low <= high && x >= arr[low] && x <= arr[high])
            {
                if (low == high)
                {
                    if (arr[low] == x)
                    {
                        return low;
                    }
                    else
                    {
                        return -1;
                    }
                }

                int pos = low + ((high - low) * (x - arr[low]) / (arr[high] - arr[low]));
                if (arr[pos] == x)
                {
                    return pos;
                }
                if (arr[pos] < x)
                {
                    low = pos + 1;
                }
                else
                {
                    high = pos - 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            int[] example = new int[8] { 13, 21, 34, 55, 69, 73, 84, 101 };
            Console.WriteLine(program.interpolationSearch(example, 8, 84));
            Console.WriteLine(program.interpolationSearch(example, 8, 21));
            Console.WriteLine(program.interpolationSearch(example, 8, 22));
        }
    }
}
