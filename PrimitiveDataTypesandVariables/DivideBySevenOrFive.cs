using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 3.	Divide by 7 and 5
Write a Boolean expression that checks for given integer if it can be divided 
 * (without remainder) by 7 and 5 in the same time. Examples:
n	Divided by 7 and 5?
3	false
0	false
5	false
7	false
35	true
140	true
*/

namespace DivideBySevenOrFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number ");
            int a = int.Parse(Console.ReadLine());

            if (a % 5 == 0)
            {
                if (a % 7 == 0)
                {
                    Console.WriteLine("Your number {0} is divided by 5 and 7", a);
                }
            }
            else Console.WriteLine("Your number does not pass the check! Try again later");

            Console.ReadLine();

        }
    }
}
