using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1.	Numbers from 1 to N
//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n,
//on a single line, separated by a space. Examples:
//n	output
//3	1 2 3
//5	1 2 3 4 5


namespace _01Numbers1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Please enter number n:");
            bool check = int.TryParse(Console.ReadLine(), out n);

            int start = 1;

            if (check)
            {
                while (start <= n)
                {
                    Console.Write("{0} ", start);
                    start++;
                }
            }
            else Console.Write("Not a valid input");

            Console.ReadLine();
        }
    }
}
