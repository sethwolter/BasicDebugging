//SethWolter 
//04/24/2015
//Claim-Academy .NET
//Project 1.1
//Exercise CheckPassFail (if-else): Write a program called CheckPassFail which 
//prints "PASS" if the int variable mark is more than or equal to 50; or prints 
//"FAIL" otherwise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassFail
{
    class Program 
    {
        static void Main(string[] args)
        {

            int yourNum;  //declares variable is to be of int type

            Console.WriteLine("Please input a positive number: ");  //asks the user for some form of numeric input
            Console.WriteLine();  //adds a space between lines on console

            yourNum = int.Parse(Console.ReadLine());  //accepts input from user... parses to 16bit int?
            Console.WriteLine();  //adds a space between lines on console

            {
                if (yourNum >= 50) //compares the variable to greater or equal to 50
                {
                    Console.WriteLine("Pass!");  //outputs phrase if condition is met
                }
                else
                {
                    Console.WriteLine("Fail");  //if variable comparison indicates that it is below 50 outputs phrase
                }
            }  
            Console.ReadLine();  //keeps console open until a keypress is detected

        }
    }
}
