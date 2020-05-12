using System;
namespace SortingAlgorithms
{
    public class Util
    {
        public Util()
        {
        }
        public static void PrintArray(int[] arr)
        {
            Console.Write("{ ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine(arr.Length - 1 + " }");
        }
    }
}
