using System;
namespace SortingAlgorithms
{
    public class BubbleSort
    {
        static int[] Arr { get; set; }
        public BubbleSort()
        {
           
        }


        public static int[] Sort(int[] unsortedArr)
        {
            Arr = unsortedArr;
            for (int i = 0; i < Arr.Length-1; i++)
            {
                for(int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        Swap(i, j);
                    }
                }
            }
            return Arr;
        }

        public static void Swap(int firstIndex, int secondIndex)
        {
            int temp = Arr[firstIndex];
            Arr[firstIndex] = Arr[secondIndex];
            Arr[secondIndex] = temp;
        }

        
    }
}
