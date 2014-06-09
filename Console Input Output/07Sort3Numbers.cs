using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 7.	Sort 3 Numbers with Nested Ifs
Write a program that enters 3 real numbers and prints them sorted in descending order.
 * Use nested if statements. Don’t use arrays and the built-in sorting functionality. Examples:
a	b	c	result
5	1	2	5 2 1
-2	-2	1	1 -2 -2
-2	4	3	4 3 -2
0	-2.5	5	5 0 -2.5
-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
10	20	30	30 20 10
1	1	1	1 1 1
*/

namespace _07Sort3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Please enter 3 real numbers, each of new line");
            bool isA = int.TryParse(Console.ReadLine(), out a);
            bool isB = int.TryParse(Console.ReadLine(), out b);
            bool isC = int.TryParse(Console.ReadLine(), out c);

            if (isA && isB && isC)
            {
                int first = a;
                int second = b;
                int third = c;

                if (b > a)
                {
                    if (c > b)
                    {
                        first = c;
                        second = b;
                        third = a;
                    }
                    else
                    {
                        first = b;
                        second = a;
                    }
                }
                else 
                {
                    if (c>a)
                    {
                        first = c;
                        second = a;
                        third = b;
                    }
                    else
                    {
                        first = a;
                        second = b;
                        third = c;
                    }
                }

                
                Console.WriteLine("The numbers are ordered in {0} >{1} > {2}", first, second, third);

                // Solution using arrays
                int[] numbersArray = new int[] { a, b, c };
                Array.Sort(numbersArray);
                Array.Reverse(numbersArray);

                foreach (int number in numbersArray)
                {
                    Console.WriteLine(number);
                }
            }
            else Console.WriteLine("This is not a valid entry");

            Console.ReadLine();
        }
    }
}
