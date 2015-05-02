//Seth Wolter
//04/27/2015
//Claim-Academy .NET
//Program 1.6:
//Exercise SumAndAverageInt (Loop): 
//Write a program called SumAndAverage to produce the sum of 1, 2, 3, ..., to an upperbound (e.g., 100)
//Also compute and display the average.
//The output shall look like: The sum is 5050 The average is 50.5 TRY:
//Modify the program to sum from 111 to 8899, and compute the average.
//Introduce an int variable called count to count the numbers in the specified range. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverageInt
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal numSum = 0.00m; //declaring some variables
            decimal numAvg = 0.00m;
            int count = 0;

            for (int i = 111; i <= 8899; i++) //for loop... this time adjusted to set new range starting at 111 and no larger than 8899
            {
                numSum = numSum + i; //simple maths to get started formula
                numAvg = numSum % 8788.00m; //average getting formula... this time more numbers in mix

                if (i <= 8899 && i >= 111) //sets range for i
                    count++; //counts for rinse and repeat action

            }

            Console.WriteLine("So you want to see some number tricks eh?"); //funny guy stuff to break the monotony
            Console.WriteLine();
            Console.WriteLine("How about we get the sum of all the numbers from say... 111 to 8899?  That's pretty random...");
            Console.WriteLine();
            Console.WriteLine((decimal)numSum);
            Console.WriteLine();
            Console.WriteLine("Not impressed?.... How about I tell you what the average of those numbers is?");
            Console.WriteLine();
            Console.WriteLine("That sure would be useful... right?");
            Console.WriteLine();
            Console.WriteLine((decimal)numAvg);
            Console.WriteLine();
            Console.WriteLine("Okay... now go away....");
            Console.WriteLine();
            Console.WriteLine("Oh, by the way... there were " + count + " numbers used in that whole mess....just sayin'");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
