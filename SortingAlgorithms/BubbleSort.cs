using System;
namespace SortingAlgorithms
{
    public class BubbleSort
    {
        int[] Arr { get; set; }
        public BubbleSort(int[] unsortedArr)
        {
            Arr = unsortedArr;
        }


        public int[] Sort()
        {
            for(int i = 0; i < Arr.Length-1; i++)
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

        public void Swap(int firstIndex, int secondIndex)
        {
            int temp = Arr[firstIndex];
            Arr[firstIndex] = Arr[secondIndex];
            Arr[secondIndex] = temp;
        }

        public void PrintArray()
        {
            Console.Write("{ ");
            for(int i = 0; i < Arr.Length - 1; i++)
            {
                Console.Write(Arr[i] + ", ");
            }
            Console.WriteLine(Arr.Length - 1+" }");
        }
    }
}
