using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 2.	Numbers Not Divisible by 3 and 7
//Write a program that enters from the console a positive integer n and prints 
//all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space. Examples:
//n	output
//3	1 2
//10	1 2 4 5 8 10


namespace _02NumbersNotDivisibleby3and5
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
                    if (!(start % 7 == 0 || start % 3 == 0))
                    {
                        Console.Write("{0} ", start);
                    }
                    start++;
                }
            }
            else Console.Write("Not a valid input");

            Console.ReadLine();
        }
    }
}
