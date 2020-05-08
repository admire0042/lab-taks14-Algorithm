using System;
using System.Collections;
using System.Collections.Generic;

namespace swapStringForArrayNegativeVals
{
    class Program
    {
        static void Main(string[] args)
        {
            //         No 7 no
        // Swap String for Array Negative Values
        // swapStringForArrayNegativeVals(arr)
        // Given an array of numbers, replace any negative values with the string 'Codebits'.
        ArrayList arr = new ArrayList(){2, -1 , 5 , -6 , 2 , 8 , -7};

        Action<ArrayList> swapStringForArrayNegativeVals = (arr) =>{

                for (int i = 0; i < arr.Count; i++)
                {
                    string aa = "Codebits";
                    if((int)arr[i] < 0)
                    {
                        arr[i] = aa;
                    }
                     Console.WriteLine(arr[i]);
                }
        };

        swapStringForArrayNegativeVals(arr);
        }
    }
}
