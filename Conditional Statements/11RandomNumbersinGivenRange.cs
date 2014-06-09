using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 11.	Random Numbers in Given Range
//Write a program that enters 3 integers n, min and max (min ≤ max) and prints n 
//random numbers in the range [min...max]. Examples:
//n	min	max	random numbers
//5	0	1	1 0 0 1 1
//10	10	15	12 14 12 15 10 12 14 13 13 11
//Note that the above output is just an example. Due to randomness, your program most 
//probably will produce different results.


namespace _11RandomNumbersinGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, min, max;
            Console.Write("Please enter number n");
            bool isIntN = int.TryParse(Console.ReadLine(), out n);

            Console.Write("Please enter  min of the range");
            bool isIntMin = int.TryParse(Console.ReadLine(), out min);

            Console.Write("Please enter max of the range");
            bool isIntMax = int.TryParse(Console.ReadLine(), out max);

            if (isIntMax && isIntMin && isIntN && (min < max))
            {
                int[] number = new int[n];
                Random random = new Random();

                for (int i = 0; i < n; i++)
                {
                    number[i] = random.Next(min, max);
                    Console.WriteLine(number[i]);
                }
            }
            else Console.WriteLine("It is not a valid entry");

            Console.ReadLine();
        }
    }
}
