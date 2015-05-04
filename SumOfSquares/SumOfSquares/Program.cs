//Seth Wolter
//05/01/2015
//Claim-Academy- .NET
//Project 1.9
//Exercise SumAndAverage-SumOfSquares (Loop)
//Write a program called SumAndAverage to produce the sum of 1, 2, 3, ..., 
//to an upperbound (e.g., 100).
//Also compute and display the average.
//Modify the program to find the "sum of the squares" of all the numbers 
//from 1 to 100, i.e. 11 + 22 + 33 + ... + 100100.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal numSum = 0m; //declaring variables....
            decimal numSqr = 0m;
            decimal numAvg = 0m;
            decimal result = 0m;
            decimal N = 100m;

            int count = 0;

            numSum = N * (N + 1) / 2; // simpler formula for delivering sum of natural numbers 1 to 100
            numSqr = (N * (N + 1) * (2 * N + 1)) / 6; // formula mod to adjust to square format... no real idea how this works... thanks google!
            //338350 is the sume of squares
            result = numSum * numSum - numSqr; // formula for delivering results 
            numAvg = result / 100m; // simple average formula

            if (N <= 100 && N >= 1) // loop that sets parameters to keep number within range of 1 to 100
            count++; // counts number of times loop runs through iteration

            Console.WriteLine();
            Console.WriteLine("Again with the math problems..."); //some very amusing dialogue.... again.. my comments are getting predictable...
            Console.WriteLine();
            Console.WriteLine("How about we get the average of the 'sum of squares' from one to one-hundred?");
            Console.WriteLine();
            Console.WriteLine("What the hell is that you say?  I'll tell you...");
            Console.WriteLine();
            Console.WriteLine("Back when Euclid was just a boy there was a standing bet that no man could... with some numbers and....");
            Console.WriteLine();
            Console.WriteLine("You're getting a glassy look in your eyes.... Fine... ");
            Console.WriteLine();
            Console.WriteLine("It's when you convert 1 to 11, and 2 to 22, 3 to 33... up to 100 to 100100... ");
            Console.WriteLine();
            Console.WriteLine("That is a pretty big honkin' number..." + result);
            Console.WriteLine();
            Console.WriteLine("Then you add the whole shabang up and average it and get the total..." + numAvg);
            Console.WriteLine();
            Console.WriteLine("Still not impressed eh?... Sheesh.... You are hard to please...");
            Console.WriteLine();
           // Console.WriteLine("By the way... there were " + count + " numbers used in that whole mess");
           // Console.WriteLine();

            Console.ReadLine();
        }
    }
}
