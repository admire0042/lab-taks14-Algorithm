using System;

namespace returnArrayCountGreaterThanY
{
    class Program
    {
        static void Main(string[] args)
        {
             // No 5
        // Count Greater than Y
        // returnArrayCountGreaterThanY(arr, y)
        // Given an array and a value Y, count and print the number of array values greater than Y.

            int[] arr = {3,1,5,6,2,8,7};

            Action<int[], int> Values = (arr, y) => {

                for (int i = 0; i < arr.Length; i++)
                {
                    if(arr[i] > y)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            };
            Values(arr, 4);
        }
    }
}
