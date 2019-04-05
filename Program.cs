using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] result = Merging.mergeSort(new int[]{9,8,7,3,2,1});
            // int[] result = Merging.sortValues(new int[]{1,2,3}, new int[]{7,8,9});            
            for(int i = 0; i < result.Length; i++){
                System.Console.WriteLine(result[i]);
            }
        }
    }
}
