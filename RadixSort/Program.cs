using System;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4] { 304, 110, 400, 17};
            int[] d = radixSort(array);
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine(d[i]);
            }
        }

        static int[] radixSort(int[] data)
        {
            int[] temp = new int[data.Length];

            for (int shift=31; shift>-1; shift--)
            {
                int j = 0;

                for(int i=0; i<data.Length; i++)
                {
                    bool move = (data[i] << shift) >= 0;  //left shift operator
                    if (shift == 0 ? !move : move)
                    {
                        data[i - j] = data[i];
                    }
                    else
                    {
                        temp[j++] = data[i];
                    }
                }
                Array.Copy(temp, 0, data, data.Length - j, j);
            }

            return data;
        }
    }
}
