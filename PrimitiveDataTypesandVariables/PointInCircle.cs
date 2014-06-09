using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:
x	y	inside	 
0	1	true	
-2	0	true	
-1	2	false	
1.5	-1	true	
-1.5	-1.5	false	
100	-30	false	
0	0	true	
0.2	-0.8	true	
0.9	-1.93	false	
1	1.655	true	
*/

namespace PointInCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter point x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter point y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (((x * x) + (y * y)) <= 4)
            {
                Console.WriteLine("The point is inside of a circle with R = 2 ");
            }
            else
            {
                Console.WriteLine("The point is not inside of a circle with R = 2 ");
            }

            Console.ReadLine();
        }
    }
}
