using System;
using System.Collections.Generic;

namespace BinarySearch
{
    //Binary Search - can only be used once a collection is sorted
    //Starts in middle and collection is halved each round
    class Program
    {
        static int binarySearch (List<int> elements, int x)
        {
            elements.Sort();
            int start = 0;  //initial left bound index
            int stop = elements.Count - 1;  //initial right bound index
            int middle = (int)((start + stop) / 2);  //initial middle index

            while (elements[middle] != x && start < stop)
            {
                if (x < elements[middle])
                {
                    stop = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
                middle = (int)((start + stop) / 2);
            }

            return (elements[middle] != x) ? -1 : middle;
        }
        static void Main(string[] args)
        {
            List<int> test = new List<int> { 5, 8, 1, 11, 3, 6, 9 };
            Console.WriteLine(binarySearch(test, 6));
            Console.WriteLine(binarySearch(test, 4));

        }
    }
}
