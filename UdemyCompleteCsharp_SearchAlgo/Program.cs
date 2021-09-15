using System;
using System.Collections.Generic;

namespace UdemyCompleteCsharp_SearchAlgo
{
    //Linear Search - one-by-one sequential search of the items
    //iterations over entire collection - not efficient on larger data sets
    class LinearSearchAlgo
    {
        static int linearSearch (List<int> elements, int x)
        {
            int length = elements.Count;
            for(int i = 0; i<length; i++)
            {
                if (elements[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            List<int> test = new List<int> { 1, 3, 5, 6, 8, 9, 11 };
            Console.WriteLine(linearSearch(test, 6));
            Console.WriteLine(linearSearch(test, 4));
        }
    }
}
