using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 6.	Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
•	Prints on the console the number in reversed order: dcba (in our example 1102).
•	Puts the last digit in the first position: dabc (in our example 1201).
•	Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0. Examples:
n	sum of digits	reversed	last digit in front	second and third digits exchanged
2011	4	1102	1201	2101
3333	12	3333	3333	3333
9876	30	6789	6987	9786
*/

namespace FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number ");
            int num = int.Parse(Console.ReadLine());

            string converted = num.ToString();
            string newConverted = "";

            if(converted.Length==4)
            {
                for(int i = converted.Length - 1; i>=0; i--)
                {
                    newConverted += converted[i];
                }
                Console.WriteLine("The reversed look of {0} is {1}", converted, newConverted);

                int a = num % 10; 
                int b = (num / 10) % 10;
                int c = (num / 100) % 10;
                int d = (num / 1000) % 10;

                int sum = a + b + c + d;
                Console.WriteLine(" The sum of {0} with digits {1} {2} {3} {4} is {5}", num, d, c, b, a, sum);

                //to have from dcba dabc
                string aString = a.ToString();
                string bString = b.ToString();
                string cString = c.ToString();
                string dString = d.ToString();

                string dabc = aString + dString + cString + bString;
                string acbd = dString + bString + cString + aString;

                Console.WriteLine("Your number {0} looks from abcd to dabc -> {1}", num, dabc);
                Console.WriteLine("Your number {0} looks from abcd to acbd -> {1}", num, acbd);
            }
            else
            {
                Console.WriteLine("The number is not of 4 digits");
            }

            Console.ReadLine();
        }
    }
}
