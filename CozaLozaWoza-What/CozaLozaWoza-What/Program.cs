//Seth Wolter
//05/01/2015
//Claim-Academy .NET
//Program 1.91
//Write a program called CozaLozaWoza which prints the numbers 1 to 110, 11 numbers 
//per line. The program shall print "Coza" in place of the numbers which are multiples 
//of 3, "Loza" for multiples of 5, "Woza" for multiples of 7, "CozaLoza" for multiples of 3 and 5, and so on. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaLozaWoza_What
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1; //declare some variable

            for (int i = 1; i <= 110; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 &&  i % 7 == 0 )
                {
                    Console.Write(" CozaLozaWoza"); //move to first 
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    Console.Write(" LozaWoza"); //move to first 
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" CozaLoza"); //move to first 
                }
                else if (i % 7 == 0)
                {
                    Console.Write(" Woza");//second
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" Loza");//third
                }
                else if (i % 3 == 0)
                { 
                    Console.Write(" Coza");//fourth
                }
                else
                {
                    Console.Write(" " + i);
                }

                if (count % 11 == 0)
                {
                    Console.WriteLine();
                }
                count++; //move to outside to keep from repeating inside 'if'
                   
            }
            Console.ReadLine();
        }
    }
}
