using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 7.	Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose k different members out of a group of n 
//different elements (also known as the number of combinations) is calculated by the following formula:
 
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops. Examples:
//n	k	n! / (k! * (n-k)!)
//3	    2	3
//4	    2	6
//10 	6	210
//52	5	2598960


namespace _07CalculateFactoriel2
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


            int factorial = 1;
            int faktorialK =1;
            int faktorialS = 1;
            int result;

            if (isIntN && isIntX)
            {
                if ((1 < k) && (1 < n) && (k < n) && (k < 100) && (n < 100))
                {

                    for (int j = n-k+1; j <= n; j++)
                    {
                        faktorialK *= j;

                        if (factorial <= k)
                        {
                            faktorialS *= factorial;
                            factorial++;
                        }
                    }
                    result = faktorialK / faktorialS;
   

                    Console.WriteLine(result);
                }

            }
            else Console.Write("Incorrect digit");

            Console.ReadLine();
        }
    }
}
