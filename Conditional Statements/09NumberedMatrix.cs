using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9.	Matrix of Numbers
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
//and prints a matrix like in the examples below. Use two nested loops. Examples:
//n	matrix		n	matrix		n	matrix
//2	1 2
//  2 3		    3	1 2 3
//                  2 3 4
//                  3 4 5		 4	  1 2 3 4
//                                    2 3 4 5
//                                    3 4 5 6
//                                    4 5 6 7


namespace _09NumberedMatrix
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
                if ((1 < n) && (n < 20))
                {

                    for (int row = 1; row <= n; row++)
                    {
                        for (int column = row; column <= row + n - 1; )
                        {
                            Console.Write("{0} ", column);
                            column++;
                        }
                        Console.WriteLine();
                    }
                }
                else Console.WriteLine("It is not a valid entry");
            }
            else Console.WriteLine("It is not a valid entry");

            Console.ReadLine();
        }
    }
}
