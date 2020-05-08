using System;

namespace printOdds1To255
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
              //  No 8 
            // Print Odds 1-255
            // printOdds1To255()Print all odd integers from 1 to 255.

                Numbers Odds1To255 = () =>{
                    for (int i = 1; i <= 255; i+=2)
                    {
                        Console.WriteLine(i);
                    }
                };

            Odds1To255();
        }
    }
}
