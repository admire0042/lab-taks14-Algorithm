using System;

namespace printMaxOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // No 3
        // Print Max of Array
        // printMaxOfArray(arr)
        // Given an array, find and print its largest element.

        Func<int[],int> largest = (a)=>{
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
             if(a[i]>max)
             {
                 max = a[i];
             }   
            }
            return max;
        };
        
        int[] arr = {4,3,1,5};
        Console.WriteLine(largest(arr));

        }
    }
}
