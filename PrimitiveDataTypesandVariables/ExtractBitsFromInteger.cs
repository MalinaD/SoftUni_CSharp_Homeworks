using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 12.	Extract Bit from Integer
Write an expression that extracts from given integer n the value of given bit at index p. Examples:
n	binary representation	p	bit @ p
5	00000000 00000101	    2   	1
0	00000000 00000000	    9	    0
15	00000000 00001111	    1   	1
5343	00010100 11011111	7   	1
62241	11110011 00100001	11  	0
*/

namespace ExtractBitsFromInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            byte value = 0;
            int n;
            byte p;
            Console.Write("Enter the integer number n:");
            bool isiInt = int.TryParse(Console.ReadLine(), out n);
            Console.Write("Enter the position of the bit p:");
            bool isbByte = byte.TryParse(Console.ReadLine(), out p);

            if (isiInt && isbByte && p < 32)
            {
                int mask = 1 << p;
                if ((n & mask) == mask)
                {
                    value = 1;
                }
                Console.WriteLine("value = {0}", value);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }

            Console.ReadLine();
        }
    }
}
