//Seth Wolter
//04/23/2015
//Claim-Academy .NET
//Program 1.3:
//Exercise SumAndAverage (Loop): 
//Write a program called SumAndAverage to produce the sum of 1, 2, 3, ..., to an upperbound (e.g., 100)
//Also compute and display the average.
//The output shall look like: The sum is 5050 The average is 50.5 TRY:


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

            double numSum = 0; //change to double to 
            double numAvg = 0.0;
            //int count = 0;

                for(int i = 1; i <= 100; i++)
                {
                    numSum = numSum + i;
                    numAvg = numSum / 100;

                   // if (i <= 100 && i >= 1)
                       // count++;
                    
                }

                Console.WriteLine("So you want to see some number tricks eh?");
                Console.WriteLine();
                Console.WriteLine("How about we get the sum of all the numbers from say... 1 to 100?");
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
                //Console.WriteLine("By the way... there were " + count + " numbers used in that whole mess");
                //Console.WriteLine();

                Console.ReadLine();

        }
    }
}
