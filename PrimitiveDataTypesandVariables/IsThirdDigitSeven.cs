using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 5.	Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7. Examples:
n	Third digit 7?
5	    false
701	    true
9703	true
877	    false
777877	false
9999799	true
*/

namespace IsThirdDigitSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number ");
            int number;

            bool check = false;

            bool isInt = int.TryParse(Console.ReadLine(), out number);
            
            if(isInt)
            {
                if(number%1000> 699 && number%1000 < 800)
                {
                    check = true;
                }

                Console.WriteLine("Is your number {0} is has third digit 7? {1}", number, check);
            }

            Console.ReadLine();
        }
    }
}
