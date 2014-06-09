using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 5.	Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
//Write a program that, for a given two integer numbers n and x, calculates the sum 
//S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits after the decimal point.
//n	x	S
//3	2	2.00000
//4	3	2.04151
//5	-4	0.75781


namespace _05CalculateSum
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, x;
            Console.WriteLine("Please enter number x: ");
            bool isIntX = double.TryParse(Console.ReadLine(), out x);

            Console.Write("Please enter number n");
            bool isIntN = double.TryParse(Console.ReadLine(), out n);

            double sum = 1;
            double number = 1;
            double factorial = 1;

            if (isIntN && isIntX)
            {
                while (number <= n)
                {
                    factorial *=number;
                    sum+=(factorial/(Math.Pow(x,number)));
                    number++;
                }
                Console.WriteLine("S= {0:0.00000}", sum);
            }
            else Console.Write("Incorrect digit");

            Console.ReadLine();
        }
    }
}
