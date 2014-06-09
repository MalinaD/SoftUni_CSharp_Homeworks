using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 14.	Modify a Bit at Given Position
We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a 
 * sequence of operators (a few lines of C# code) that modifies n to hold the 
 * value v at the position p from the binary representation of n while preserving all other bits in n. 
 * Examples:
n	binary representation of n	p	v	binary result	result
5	00000000 00000101	    2	0	00000000 00000001	1
0	00000000 00000000	    9	1	00000010 00000000	512
15	00000000 00001111	    1	1	00000000 00001111	15
5343	00010100 11011111	7	0	00010100 01011111	5215
62241	11110011 00100001	11	0	11110011 00100001	62241
*/

namespace ModifyBitatGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            byte value, p;
            int n;
            Console.Write("Enter the integer number n:");
            bool isnInt = int.TryParse(Console.ReadLine(), out n);
            Console.Write("Enter the value of the bit:");
            bool isValueByte = byte.TryParse(Console.ReadLine(), out value);
            Console.Write("Enter the position of the bit p:");
            bool ispByte = byte.TryParse(Console.ReadLine(), out p);

            if (isnInt && isValueByte && ispByte && value < 2 && p < 32)
            {

                int mask = 1 << p;
                if (value == 1)
                {
                    n = n | mask;
                }
                else
                {
                    if ((n & mask) == mask)
                    {
                        n = n ^ mask;
                    }
                }
                Console.WriteLine("n={0}", n);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }



            Console.ReadLine();
        }
    }
}
