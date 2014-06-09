using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 4.	Rectangles
Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
width	height	perimeter	area
3	    4	      14	        12
2.5  	3	      11	      7.5
5	    5	      20	      25
*/

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a weidth ");
            double weidth = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a height ");
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * (weidth + height);
            double area = weidth * height;

            Console.WriteLine("By given weidth {0} and height {1} of rectangle we have:", weidth, height);
            Console.WriteLine("area of {0}", area);
            Console.WriteLine("and parameter of {0}", perimeter);

            Console.ReadLine();
        }
    }
}
