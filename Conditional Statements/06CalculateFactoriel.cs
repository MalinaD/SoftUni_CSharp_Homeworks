using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 6.	Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. Examples:
//n	k	n! / k!
//5	2	60
//6	5	6
//8	3	6720


namespace _06CalculateFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Please enter number k: ");
            bool isIntX = int.TryParse(Console.ReadLine(), out k);

            Console.Write("Please enter number n");
            bool isIntN = int.TryParse(Console.ReadLine(), out n);


            int factorialN = 1;

            if (isIntN && isIntX)
            {
                if ((1 < k) && (1< n)&& (k<n)&&(k< 100)&&(n<100))
                {


                    for (int i = n; i > k; i--)
                    {
                        factorialN = factorialN * i;
                    }
                    Console.WriteLine(factorialN );
                }
                
            }
            else Console.Write("Incorrect digit");

            Console.ReadLine();
        }
    }
}
