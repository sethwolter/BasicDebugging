//Seth Wolter
//04/23/2015
//Claim-Academy .NET
//Program 1.5:
//Exercise SumAndAverageOver (Loop): 
//Write a program called SumAndAverage to produce the sum of 1, 2, 3, ..., to an upperbound (e.g., 100)
//Also compute and display the average.
//The output shall look like: The sum is 5050 The average is 50.5 TRY:
//Modify the program to sum from 111 to 8899, and compute the average. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal numSum = 0.00m; //declaring some variables
            decimal numAvg = 0.00m;
            int count = 0;

                for(int i = 111; i <= 8899; i++) //setting the for loop... where to start... how long. etc...
                {
                    numSum = numSum + i; //doing the maths
                    numAvg = numSum % 8788.00m; //getting the average

                    if (i <= 8899 && i >= 111) //setting the 'if' to count range for the count++
                        count++; //running through to get a total of numbers used
                    
                }

                Console.WriteLine("So you want to see some number tricks eh?"); //again with the dialogue
                Console.WriteLine();
                Console.WriteLine("How about we get the sum of all the numbers from say... 111 to 8899?");
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
                Console.WriteLine("By the way... there were " + count + " numbers used in that whole mess");
                Console.WriteLine();

                Console.ReadLine();

        }
    }
}