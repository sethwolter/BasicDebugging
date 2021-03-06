﻿//Seth Wolter
//04/23/2015
//Claim-Academy .NET
//Program 1.2:
//Exercise PrintNumberInWord (switch-case): 
//Write a program called PrintNumberInWord which prints "ONE", "TWO",... , "NINE", "OTHER" 
//if the int variable number is 1, 2,... , 9, or other, respectively.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Welcome to Seth's simple number to word text converter.");
            Console.WriteLine();
            Console.WriteLine("I appreciate you being here!");
            Console.WriteLine();
            Console.WriteLine("Basically, you are going to enter a number and");
            Console.WriteLine();
            Console.WriteLine("I will convert it to its word/text equivalent...");
            Console.WriteLine();
            Console.WriteLine("Pretty flippin' amazing huh?");
            Console.WriteLine();
            Console.WriteLine("To get going, let's have you enter a number between 1 and 10: ");
            Console.WriteLine();

            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int caseSwitch = num1;
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Your number is ONE!");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Your number is TWO!");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Your number is THREE!");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Your number is FOUR!");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine("Your number is FIVE!");
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("Your number is SIX!");
                    Console.WriteLine();
                    break;
                case 7:
                    Console.WriteLine("Your number is SEVEN!");
                    Console.WriteLine();
                    break;
                case 8:
                    Console.WriteLine("Your number is EIGHT!");
                    Console.WriteLine();
                    break;
                case 9:
                    Console.WriteLine("Your number is NINE!");
                    Console.WriteLine();
                    break;
                case 10:
                    Console.WriteLine("Your number is TEN!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Okay.. I thought we agreed your input would be a number between 1 and 10.");
                    Console.WriteLine();
                    Console.WriteLine("Obviously, I'm not smart enough to translate " + num1 + " Yet...");
                    Console.WriteLine();
                    break;
            }

            Console.ReadLine();

        }
    }
}
