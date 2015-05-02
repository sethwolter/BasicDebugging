//Seth Wolter
//04/25/2015
//Claim-Academy .NET
//Program 1.4:
//Exercise SumAndAverage (Loop): 
//Write a program called SumAndAverage to produce the sum of 1, 2, 3, ..., to an upperbound (e.g., 100)
//Also compute and display the average.
//The output shall look like: The sum is 5050 The average is 50.5 TRY:
//Modify the program to use a "while" loop instead of "for" loop.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverage_While
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numSum = 0.00m; //declaring variables
            decimal numAvg = 0.00m;

            int i = 0;

            while (i <= 100) //beginning of while loop
            {
                numSum = numSum + i; //formula/maths for numSum
                numAvg = numSum % 100.00m; //formula for getting average
                i++; //looping back and counting
            }

            Console.WriteLine("So you want to see some number tricks eh?"); //again with teh amusing dialogue...
            Console.WriteLine();
            Console.WriteLine("How about we get the sum all the numbers from 1 to 100?");
            Console.WriteLine();
            Console.WriteLine((decimal)numSum);
            Console.WriteLine();
            Console.WriteLine("Not impressed?.... How about we get the average of those numbers?");
            Console.WriteLine();
            Console.WriteLine("That sure would be useful... right?");
            Console.WriteLine();
            Console.WriteLine((decimal)numAvg);
            Console.WriteLine();
            Console.WriteLine("Okay... now go away....");
            Console.ReadLine();
        

        }
    }
}
