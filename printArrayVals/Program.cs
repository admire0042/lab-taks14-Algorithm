using System;

namespace printArrayVals
{
    class Program
    {
        static void Main(string[] args)
        {
           //  No 9
                // Print Array Values
                // printArrayVals(arr)
                // Iterate through a given array, printing each value.

                int[] arr = {3,-1,5,-6,2,8,-7};
                Action<int[]> printArrayVals = (arr) => {
                
                    foreach (var item in arr)
                    {
                        Console.WriteLine(item);
                    }
                }; 

                printArrayVals(arr);
        }
    }
}
