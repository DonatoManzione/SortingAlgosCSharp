using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 8, 5, 2, 7, 5, 1, 6, 9 };
            arr = Bubble.Sort(arr);
            Util.Print(arr);
        }
    }
}
