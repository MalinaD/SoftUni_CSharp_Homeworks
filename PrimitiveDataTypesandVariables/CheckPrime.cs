using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 8.	Prime Number Check
Write an expression that checks if given positive integer number n (n ≤ 100) is prime
 * (i.e. it is divisible without remainder only to itself and 1). Examples:
n	Prime?
1	false
2	true
3	true
4	false
9	false
97	true
51	false
-3	false
0	false
*/

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Въведи число x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            bool check = true;

            if((x > 0) && (x <= 100)) 
            {

                        for (int i = 2; i <= Math.Sqrt(x); i++)
                        {
                            if(x%i==0)
                            {
                                check = false;
                            } 
                           
                        }
                        Console.WriteLine("Твоето число {0} е просто ? {1}", x, check);


            }
            else Console.WriteLine("Опитай пак");

            Console.ReadLine();
        }
    }
}
