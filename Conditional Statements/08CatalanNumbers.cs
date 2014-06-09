using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 8.	Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the following formula:
  
//Write a program to calculate the nth Catalan number by given n (1 < n < 100). Examples:
//n	Catalan(n)
//0	1
//5	42
//10	16796
//15	9694845


namespace _08CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Please enter number n");
            bool isIntN = int.TryParse(Console.ReadLine(), out n);

            if (isIntN)
            {
                if ((1 < n) && (n < 100))
                {
                    int result = 1;
                    int factorial = 1, factorial2 = 1;

                    for (int i = 2; i <= n; i++)
                    {
                        result *= ((n + i) / i);
                    }

                    Console.WriteLine(result);

                    Console.WriteLine();

                    for (int i = 1, j = (n + 1); i <= n; i++, j++)
                    {
                        factorial *= i;
                        factorial2 *= j;
                    }
                    result = (factorial2 * factorial) / (((n + 1) * factorial) * factorial);
                    Console.WriteLine("The Catalan numbers is: {0}", result);
                }
                else Console.Write("Not a valid digit");
            }
            else Console.Write("Not a valid digit");

            Console.ReadLine();
        }
    }
}
