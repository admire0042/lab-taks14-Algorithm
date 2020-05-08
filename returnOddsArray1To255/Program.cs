using System;
using System.Collections;
using System.Collections.Generic;

namespace returnOddsArray1To255
{
    class Program
    {
        public delegate void Numbers();
        static void Main(string[] args)
        {
            // No 4
        // Return Odds Array 1-255
        // returnOddsArray1To255()
        // Create an array with all the odd integers between 1 and 255 (inclusive).Return Array

            Numbers OddsArr = () =>{

                List<int> arr = new List<int>();
                
                for (int i = 1; i <= 255; i+=2)
                {
                    arr.Add(i);
                }
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            };
            OddsArr();

        }
    }
}
