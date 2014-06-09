using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write an expression that checks if given integer is odd or even. Examples:
n	Odd?
3	true
2	false
-2	false
-1	true
0	false
*/

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number ");
            int a = int.Parse(Console.ReadLine());
            string odd = "odd";
            string even = "even";

            if(a%2==0)
            {
                
                Console.WriteLine("Your number {0} is {1}",a,even);
            }
            else
            {
                Console.WriteLine("Your number {0} is {1}", a, odd);
            }

            Console.ReadLine();
        }
    }
}
