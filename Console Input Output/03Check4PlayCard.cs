using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 3.	Check for a Play Card
Classical play cards use the following signs to designate the card face: 
 * 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and 
 * prints “yes” if it is a valid card sign or “no” otherwise. Examples:
character	Valid card sign?
5	yes
1	no
Q	yes
q	no
P	no
10	yes
500	no
*/

namespace _03Check4PlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter card sign: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A");
            char card = char.Parse(Console.ReadLine());

            int value = Convert.ToInt16(card);
            if (card == 'A' || card == 'K' || card == 'J' || card == 'Q')
            {
                Console.WriteLine("Yes");

            }
            else if (value < 10 && value > 0)
            {
                Console.WriteLine("Yes");
            }
            else Console.Write("No");

            Console.ReadLine();
        }
    }
}
