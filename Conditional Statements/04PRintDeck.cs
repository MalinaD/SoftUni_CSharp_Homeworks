using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4.	Print a Deck of 52 Cards
//Write a program that generates and prints all possible cards from a standard deck of 52 cards 
//(without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). 
//The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds,
//hearts and spades. Use 2 nested for-loops and a switch-case statement.
//output
//2♣ 2♦ 2♥ 2♠
//3♣ 3♦ 3♥ 3♠
//…
//K♣ K♦ K♥ K♠
//A♣ A♦ A♥ A♠


namespace _04PRintDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 255; i++)
            // {
            //    Console.Write("The ASCII character {0} is ", i);
            //    Console.WriteLine((char)i);
            // }

            for (int i = 2; i <= 10; i++)
            {
                Console.Write("{0}{1} ", i,(char)3);
                Console.Write("{0}{1} ", i, (char)4);
                Console.Write("{0}{1} ", i, (char)5);
                Console.WriteLine("{0}{1} ", i, (char)6);
            }

            Console.Write("{0}{1} ", (char)65, (char)3);
            Console.Write("{0}{1} ", (char)65, (char)4);
            Console.Write("{0}{1} ", (char)65, (char)5);
            Console.WriteLine("{0}{1} ", (char)65, (char)6);

            Console.Write("{0}{1} ", (char)74, (char)3);
            Console.Write("{0}{1} ", (char)74, (char)4);
            Console.Write("{0}{1} ", (char)74, (char)5);
            Console.WriteLine("{0}{1} ", (char)74, (char)6);

            Console.Write("{0}{1} ", (char)75, (char)3);
            Console.Write("{0}{1} ", (char)75, (char)4);
            Console.Write("{0}{1} ", (char)75, (char)5);
            Console.WriteLine("{0}{1} ", (char)75, (char)6);

            Console.Write("{0}{1} ", (char)81, (char)3);
            Console.Write("{0}{1} ", (char)81, (char)4);
            Console.Write("{0}{1} ", (char)81, (char)5);
            Console.WriteLine("{0}{1} ", (char)81, (char)6);



            Console.ReadLine();
        }
    }
}
