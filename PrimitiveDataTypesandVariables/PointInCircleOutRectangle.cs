using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 10.	Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle 
 * R(top=1, left=-1, width=6, height=2). Examples:
x	y	inside K & outside of R	 
1	2	yes	
2.5	2	no	
0	1	no	
2.5	1	no	
2	0	no	
4	0	no	
2.5	1.5	no	
2	1.5	yes	
1	2.5	yes	
-100	-100	no	
*/

namespace PointInCircleOutRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            double x, y;
            Console.Write("Enter point x: ");
            bool Xcheck = double.TryParse(Console.ReadLine(), out x);

            Console.Write("Enter point y: ");
            bool Ycheck = double.TryParse(Console.ReadLine(), out y);

            if (Xcheck && Ycheck)
            {
                if (!((x >= -1 && y >= -1) && (x <= 5 && y <= 1)))
                {
                    double displacedX = x - 1;
                    double displacedY = y - 1;

                    if ((displacedX * displacedX + displacedY * displacedY) <= 2.25)
                    {
                        check = true;
                    }
                    Console.WriteLine("Is the point ({0},{1}) within the circle and out of the rectangle?:{2}",x,y, check);
                }
                else Console.WriteLine("The point ({0},{1}) is not within the circle and out of the rectangle", x,y);
                
            }
            else Console.WriteLine("it is not a valid entry");
            Console.ReadLine();
        }
    }
}
