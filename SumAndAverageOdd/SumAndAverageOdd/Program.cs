//Seth Wolter
//04/28/2015
//Claim-Academy .NET
//Program 1.7:
//Exercise SumAndAverageOdd (Loop): 
//Write a program called SumAndAverage to produce the sum of 1, 2, 3, ..., to an upperbound (e.g., 100)
//Also compute and display the average.
//The output shall look like: The sum is 5050 The average is 50.5 TRY:
//Introduce an int variable called count to count the numbers in the specified range.
// Modify the program to sum only the odd numbers from 1 to 100, and compute the average. 
//(Hint: n is an odd number if n % 2 is not 0.)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverageOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numSum = 0.00m; //declaring some variables
            decimal numAvg = 0.00m;
            int count = 0;

            for (int i = 0; i <= 100; i = i + 2) //for loop.. sets beginning, end and how many... notice the i + 2... adds 2 to starting point 1
                {
                    numSum = numSum + i; //establishes numsum value added to i
                    numAvg = numSum % 100; //gets us teh average

                    count++; //returns the rinse and repeat functionality...
                }

                Console.WriteLine("More number tricks eh?... Man you are nothing if not predictable..."); // this guy... funny you know
                Console.WriteLine();
                Console.WriteLine("This time, lets see how many odd numbers there are between 1 and 100...");
                Console.WriteLine();
                Console.WriteLine("There are " + count + " odd numbers between 1 and 100...");
                Console.WriteLine();
                Console.WriteLine("Oh, by the way... the sum of all of those odd numbers is: ");
                Console.WriteLine();
                Console.WriteLine((decimal)numSum);
                Console.WriteLine();
                Console.WriteLine("and the average is: ");
                Console.WriteLine();
                Console.WriteLine((decimal)numAvg);

                Console.ReadLine();

        }
    }
}
