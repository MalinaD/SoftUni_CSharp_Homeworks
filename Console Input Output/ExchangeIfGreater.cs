using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 1.	Exchange If Greater
Write an if-statement that takes two integer variables a and b and exchanges their 
 * values if the first one is greater than the second one. As a result print the 
 * values a and b, separated by a space. Examples:
a	b	result
5	2	2 5
3	4	3 4
5.5	4.5	4.5 5.5
*/

namespace ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {

            int a,b;
            Console.Write("Enter two integer numbers, one by line:");
            bool isnInt = int.TryParse(Console.ReadLine(), out a);
            bool isnInt2 = int.TryParse(Console.ReadLine(), out b);

            if (isnInt && isnInt2)
            {

                if (a > b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }

                Console.WriteLine("The numbers you entered after exchange are {0} and {1}", a, b);
            }
            else Console.WriteLine("This is not correct number, please try again!");

            Console.ReadLine();
        }
    }
}
