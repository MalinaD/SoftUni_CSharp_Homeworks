using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 5.	The Biggest of 3 Numbers
Write a program that finds the biggest of three numbers. Examples:
a	b	c	biggest
5	2	2	5
-2	-2	1	1
-2	4	3	4
0	-2.5	5	5
-0.1	-0.5	-1.1	-0.1
*/

namespace _05BiggestOf3
{
    class Program
    {
        static void Main(string[] args)
        {
             int a,b,c;
            Console.Write("Please enter 3 numbers ");
            bool isnInta = int.TryParse(Console.ReadLine(), out a);
            bool isnIntb = int.TryParse(Console.ReadLine(), out b);
            bool isnIntc = int.TryParse(Console.ReadLine(), out c);

            int biggest, bigger, smallest;
            if (isnInta && isnIntb && isnIntc)
            {
                 if(a>b)
                 {

                     biggest = a;
                     bigger = b;
                     smallest = c;
                 }
                 else if (b > c)
                 {
                     biggest = b;
                     if (a > c)
                     {
                         bigger = a;
                         smallest = c;
                     }
                     else
                     {
                         bigger = c;
                         smallest = a;
                     }
                 }
                 else
                 {
                     biggest = c;
                     bigger = b;
                     smallest = a;
                 }

                 Console.WriteLine("Your numbers are {0} > {1} > {2}", biggest, bigger, smallest);

                 Console.ReadLine();
            }
        }
    }
}
