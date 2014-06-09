using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 6.	The Biggest of Five Numbers
Write a program that finds the biggest of five numbers by using only five if statements. Examples:
a	b	c	d	e	biggest
5	2	2	4	1	5
-2	-22	1	0	0	1
-2	4	3	2	0	4
0	-2.5	0	5	5	5
-3	-0.5	-1.1	-2	-0.1	-0.1
*/

namespace _06BiggestOf5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,e;
            Console.Write("Please enter 5 numbers, each of new row ");
            bool isnInta = int.TryParse(Console.ReadLine(), out a);
            bool isnIntb = int.TryParse(Console.ReadLine(), out b);
            bool isnIntc = int.TryParse(Console.ReadLine(), out c);
            bool isnIntd = int.TryParse(Console.ReadLine(), out d);
            bool isnInte = int.TryParse(Console.ReadLine(), out e);

            int biggest=a;
            if (isnInta && isnIntb && isnIntc && isnIntc && isnIntd)
            {
                if(b>a)
                {
                    biggest = b;
                }

                if (c > b)
                {
                    biggest = c;
                }

                if (d > c)
                {
                    biggest = d;
                }

                if (e > d)
                {
                    biggest = e;
                }

                Console.WriteLine("The biggest number is {0}", biggest);
            }

            Console.ReadLine();
        }
    }
}
