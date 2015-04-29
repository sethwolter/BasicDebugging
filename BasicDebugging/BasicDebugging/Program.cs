using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 10000, deposit = 0, withdrawl = 0;

            
            //balance = balance - withdrawl;

            Console.WriteLine("Hello and welcome to the weirdest bank in the world!");
            Console.WriteLine();
            Console.WriteLine("Your current balance is: " + balance);
            Console.WriteLine();

            Console.WriteLine("How much would you like to deposit?:   ");
            deposit = Convert.ToInt32(Console.ReadLine());
            balance = balance + deposit;
            Console.WriteLine("Your current balance is: " + balance);
            Console.WriteLine();

            Console.WriteLine("How much would you like to withdraw?:   ");
            withdrawl = Convert.ToInt32(Console.ReadLine());
            balance = balance - withdrawl;
            Console.WriteLine("Your current balance is: " + balance);
            Console.WriteLine();

            Console.ReadLine();

            //int beginVal = 0;
            //while (beginVal <= 5)
            //{
                //Deposit logic

                //Withdrawal logic

            //    beginVal++;
            //}
        }
    }
}
