using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Trailing Zeroes in N!
//Write a program that calculates with how many zeroes the factorial of a given 
//number n has at its end. Your program should work well for very big numbers,
//e.g. n=100000. Examples:
//n	trailing zeroes of n!	explaination
//10	2	3628800
//20	4	2432902008176640000
//100000	24999	think why


namespace _18TrailingZerosinN
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            BigInteger factorial = 1;

            int count=0;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            for (int i = 5; number / i >= 1; i *= 5)
           {
            count += number / i;
            }

            Console.WriteLine("trailing zeroes of n! = " + count);

           //Console.WriteLine("trailing zeroes of n! = " + (number / 5));
           Console.Write(factorial);

           Console.ReadLine();
        }
    }
}
