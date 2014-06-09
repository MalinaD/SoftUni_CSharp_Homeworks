using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Digit as Word
//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Print “not a digit” in case of invalid inut. Use a switch statement. Examples:
//d	result
//2	two
//1	one
//0	zero
//5	five
//-0.1	not a digit
//hi	not a digit
//9	nine
//10	not a digit


namespace _09DigitAsWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a digit:");
            int digit = int.Parse(Console.ReadLine());

            Console.Write("The word of digit {0} is:", digit);
            switch (digit)
            {
                case 0: Console.Write("The word of digit {0} is zero",digit); break;
                case 1: Console.Write("The word of digit {0} is one", digit); break;
                case 2: Console.Write("The word of digit {0} is two", digit); break;
                case 3: Console.Write("The word of digit {0} is three", digit); break;
                case 4: Console.Write("The word of digit {0} is four", digit); break;
                case 5: Console.Write("The word of digit {0} is five", digit); break;
                case 6: Console.Write("The word of digit {0} is six", digit); break;
                case 7: Console.Write("The word of digit {0} is seven", digit); break;
                case 8: Console.Write("The word of digit {0} is eight", digit); break;
                case 9: Console.Write("The word of digit {0} is nine", digit); break;
                default: Console.WriteLine("It is not a valid digit"); break;
            }

            Console.ReadLine();
        }
    }
}
