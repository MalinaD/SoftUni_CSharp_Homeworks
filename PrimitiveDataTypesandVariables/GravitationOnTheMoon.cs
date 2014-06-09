using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 2.	Gravitation on the Moon
The gravitational field of the Moon is approximately 17% of that on the Earth. 
 * Write a program that calculates the weight of a man on the moon by a given weight on the Earth. 
 * Examples:
weight	weight on the Moon
86	    14.62
74.6	12.682
53.7	9.129
*/

namespace GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a weight ");
            float weight = float.Parse(Console.ReadLine());

            float moonWeight = (weight * 17) / 100;
            Console.WriteLine("The weight on the Moon by given weight {0} is {1}", weight, moonWeight);

            Console.ReadLine();

        }
    }
}
