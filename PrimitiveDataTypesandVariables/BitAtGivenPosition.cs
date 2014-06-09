using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 13.	Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p 
 * (counting from 0, starting from the right) in given integer number n has value of 1. Examples:
n	binary representation of n	p	bit @ p == 1
5	00000000 00000101	2	true
0	00000000 00000000	9	false
15	00000000 00001111	1	true
5343	00010100 11011111	7	true
62241	11110011 00100001	11	false
*/

namespace BitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            byte value = 0;
            bool check = true;
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

                if (value == 1)
                {
                    check = true;
                    Console.WriteLine("Is your number {0} has at position {1} bit with value 1? {2}", n, p, check);
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
