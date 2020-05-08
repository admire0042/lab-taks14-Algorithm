using System;

namespace print1To255
{
    class Program
    {
        public delegate void Numbers();
        static void Main(string[] args)
        {
            // No 1
            // Print 1-255
            // print1To255()
            // Print all the integers from 1 to 255.


            Numbers print1To255 = () =>{
                
                for (int i = 1; i <= 255; i++)
                {
                    Console.WriteLine(i);
                    
                }
                
            };
                print1To255();

        }
    }
}
