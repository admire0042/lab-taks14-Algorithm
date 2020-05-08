using System;
using System.Collections;
using System.Collections.Generic;

namespace shiftArrayValsLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            //            No 13 check
                // Shift Array Values Left
                // shiftArrayValsLeft(arr)
                // Given an array, move all values forward (to the left) by one index, dropping the first value and leaving a 0 (zero) value at the end of the array.

                     int[] arr = {3, -1, 5, -6, 2, -8, 7, -9};
                    Action<int[]>  shiftArrayValsLeft = (arr) => {
                        
                        List<int> array = new List<int>(arr);
                        array.RemoveAt(0);
                        array.Add(0);
                        
                        foreach (var item in array)
                        {
                            Console.WriteLine(item);
                        }
                       
                };

                shiftArrayValsLeft(arr);
        }
    }
}
