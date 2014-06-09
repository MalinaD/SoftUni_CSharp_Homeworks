using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 16.	** Bit Exchange (Advanced)
Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
 * The first and the second sequence of bits may not overlap. Examples:
n	p	q	k	binary representation of n	binary result	result
1140867093	3	24	3	01000100 00000000 01000000 00010101	01000010 00000000 01000000 00100101	1107312677
4294901775	24	3	3	11111111 11111111 00000000 00001111	11111001 11111111 00000000 00111111	4194238527
2369124121	2	22	10	10001101 00110101 11110111 00011001	01110001 10110101 11111000 11010001	1907751121
987654321	2	8	11	-	-	overlapping
123456789	26	0	7	-	-	out of range
33333333333	-1	0	33	-	-	out of range
*/

namespace BitsExchange2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            byte p, q, k;
            Console.Write("Enter the unsigned integer number n:");
            bool isnInt = uint.TryParse(Console.ReadLine(), out n);
            Console.Write("Enter the start position of the first bit sequence p:");
            bool ispByte = byte.TryParse(Console.ReadLine(), out p);
            Console.Write("Enter the start position of the second bit sequence q:");
            bool isqByte = byte.TryParse(Console.ReadLine(), out q);
            Console.Write("Enter the lenght of the sequence k:");
            bool iskByte = byte.TryParse(Console.ReadLine(), out k);

            if (isnInt & ispByte & isqByte & iskByte)
            {
                if ((p + k) < 31 && (q + k) < 31 && (Math.Abs(p - q) >= k))
                {
                    if (p > q)
                    {
                        byte temp = q;
                        q = p;
                        p = temp;
                    }
                    Console.WriteLine("binary initial n:");
                    Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

                    n = ((~(((uint)Math.Pow(2, k) - 1) << q | ((uint)Math.Pow(2, k) - 1) << p)) & n) | (((n & (((uint)Math.Pow(2, k) - 1) << p)) << (Math.Abs(p - q))) | ((n & (((uint)Math.Pow(2, k) - 1) << q)) >> (Math.Abs(p - q))));//Swap bits p with bits q
                    Console.WriteLine("binary new n:");
                    Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                }
                else
                {
                    Console.WriteLine("Not a valid entry!");
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }

            Console.ReadLine();
        }
    }
}
