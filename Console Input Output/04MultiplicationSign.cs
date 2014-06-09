using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 4.	Multiplication Sign
Write a program that shows the sign (+, - or 0) of the product of three real numbers,
 * without calculating it. Use a sequence of if operators. Examples:
a	b	c	result
5	2	2	+
-2	-2	1	+
-2	4	3	-
0	-2.5	4	0
-1	-0.5	-5.1	-
*/

namespace _04MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 3 real numbers, each of new row ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                bool sign = true;

                if (a < 0)
                {
                    sign = !sign;
                }

                if (b < 0)
                {
                    sign = !sign;
                }

                if (c < 0)
                {
                    sign = !sign;
                }

                Console.WriteLine(sign ? "+" : "-");
            }


            Console.ReadLine();
        }
    }
}
