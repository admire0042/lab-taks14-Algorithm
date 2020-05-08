using System;

namespace zeroOutArrayNegativeVals
{
    class Program
    {
        static void Main(string[] args)
        {
             //  No 12 check
        // Zero Out Array Negative Numbers
        // zeroOutArrayNegativeVals(arr)
        // Return the given array, after setting any negative values to zero.


                     int[] arr = {3, -1, 5, -6, 2, -8, 7, -9};
                    Action<int[]>  zeroOutArrayNegativeVals = (arr) => {

                        for (int i = 0; i < arr.Length; i++)
                        {
                            if(arr[i] < 0){
                                arr[i] = 0;
                            }
                        Console.WriteLine(arr[i]);
                        }
                };

                zeroOutArrayNegativeVals(arr);
        }
    }
}
