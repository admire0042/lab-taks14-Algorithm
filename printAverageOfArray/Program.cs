using System;

namespace printAverageOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //  No 10
                // Print Average of Array
                // printAverageOfArray(arr)
                // Analyze an array’s values and print the average.

                int[] arr = {3, 1, 5, 6, 2, 8, 7};
                Action<int[]>  printAverageOfArray = (arr) => {
                        
                        double sum = 0;
                        foreach (var item in arr)
                        {
                            sum += item;
                        }
                        double average = sum/arr.Length;

                        Console.WriteLine($"The average of the numbers is {average:f}");
                };

                printAverageOfArray(arr);
        }
    }
}
