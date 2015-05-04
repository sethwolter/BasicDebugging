//Seth Wolter
//04/27/2015
//Claim-Academy .NET
//Program 1.8:
//Exercise SumAndAverageDiv7 (Loop): 
//Write a program called SumAndAverage to produce the sum of 1, 2, 3, ..., to an upperbound (e.g., 100)
//Also compute and display the average.
//The output shall look like: The sum is 5050 The average is 50.5 TRY:
//Modify the program to sum those numbers from 1 to 100 that is divisible by 7, and compute the average. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverageDiv7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numSum = 0.00m; //declaring some variables
            decimal numAvg = 0.00m;
            double count = 0;

            for (int i = 0; i <= 100; i++) //for loop sets limits, how many times, etc...
            {
               
                if (i % 7 == 0) //if statement formula dividing 'i' by seven to get multiples of seven
                {
                    numSum = numSum + i; //getting the answer
                    numAvg = numSum % 100; //figuring out how many times/average
                    count++; //rinse and repeat
                }
            }
            count = 100 / 7;

            Console.WriteLine("More number tricks eh?... Man you are nothing if not predictable..."); //same dialogue again.. this guy is getting predictable
            Console.WriteLine();
            Console.WriteLine("This time, lets see how many times seven goes into 100...");
            Console.WriteLine();
            Console.WriteLine("There are " + count + " sevens in 100...");
            Console.WriteLine();
            Console.WriteLine("Oh, by the way... the sum of all of those sevens is: ");
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
