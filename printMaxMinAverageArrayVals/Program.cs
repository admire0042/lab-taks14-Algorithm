using System;

namespace printMaxMinAverageArrayVals
{
    class Program
    {
        static void Main(string[] args)
        {
            //              No 6 
            // Print Max, Min, Average Array Values
            // printMaxMinAverageArrayVals(arr)
            // Given an array, print the max, min and average values for that array.

                int[] arr = {3,1,5,6,2,8,7};

                Action<int[]> MinMaxAv = (arr) =>{

                    double sum = 0;
                    double max = arr[0];
                    double min = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                    if(max < arr[i])
                    {
                        max = arr[i];
                    }
                    if(min > arr[i])
                    {
                        min = arr[i];
                    }
                    
                }
                    double average = sum/arr.Length;

                Console.WriteLine($"Maximum is : {max}\n Minimum is: {min}\nAverage is: {average:f}");
            };

            MinMaxAv(arr);
        }
    }
}
