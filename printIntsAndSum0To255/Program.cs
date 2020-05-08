using System;

namespace printIntsAndSum0To255
{
    public delegate void Numbers();
    class Program
    {
        static void Main(string[] args)
        {
        //     No 2
        // printIntsAndSum0To255()
        // Print integers from 0 to 255, and with each integer print the sum so far.
        
        Numbers print0To255 = () =>{
                int sum = 0;
                for (int i = 0; i <= 255; i++)
                {
                    Console.WriteLine($"{i} : {sum += i}");
                   
                }
                
            };
                print0To255();

        }
    }
}
