using System;
using System.Collections;
using System.Collections.Generic;

namespace squareArrayVals
{
    class Program
    {
        static void Main(string[] args)
        {
            //  No 11
                // Square Array Values
                // squareArrayVals(arr)
                // Square each value in a given array, returning that same array with changed values.

                    int[] arr = {3, 1, 5, 6, 2, 8, 7};
                    Action<int[]>  squareArrayVals = (arr) => {
                        
                        List<int> array = new List<int>();

                        foreach (int item in arr)
                        {
                            array.Add((int)Math.Pow(item,2));
                        }
                        
                        foreach (int item in array)
                        {
                            Console.WriteLine(item);
                        }
                       
                };

                squareArrayVals(arr);
        }
    }
}
