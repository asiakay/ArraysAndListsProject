using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // DONE - Create an int Array and populate numbers 1-10

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int item in array)
            {
                Console.WriteLine($"array item #{item}");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            /* DONE - Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            List<int> even = new List<int>();
            List<int> odd = new List<int>();





            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */


            for (int i =2; i<=10; i += 2)
            {
                even.Add(i);
             
            }
            foreach (int item in even)
            {
                Console.WriteLine($"Even list item #{item}");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            for (int i=1; i<=10; i +=2)
            {
                odd.Add(i);
            }
            foreach (int item in odd)
            {
                Console.WriteLine($"Odd list item #{item}");
            }
                

            

        }
    }
}
