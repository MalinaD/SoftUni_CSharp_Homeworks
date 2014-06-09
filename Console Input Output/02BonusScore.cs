using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that applies bonus score to given score in the range [1…9] by the following rules:
•	If the score is between 1 and 3, the program multiplies it by 10.
•	If the score is between 4 and 6, the program multiplies it by 100.
•	If the score is between 7 and 9, the program multiplies it by 1000.
•	If the score is 0 or more than 9, the program prints “invalid score”.
Examples:
score	result
2	20
4	400
9	9000
-1	invalid score
10	invalid score
*/

namespace _02BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.Write("Please enter score number ");
            bool isnInt = int.TryParse(Console.ReadLine(), out score);
            int result=1;

            if(isnInt)
            {
                switch(score)
                {
                    case 1:
                    case 2:
                    case 3:
                        result *= 10;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        result *= 100;
                        break;
                    case 7:
                    case 8:
                    case 9:
                        result *= 1000;
                        break;
                    default:
                        Console.WriteLine("Invalid entry!");break;
                }
                Console.WriteLine("The corresponding result is {0} ", (result * score));
            }

            Console.ReadLine();
        }
    }
}
