using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9.	Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one. If the variable is a string, 
//the program appends "*" at the end. Print the result at the console. Use switch statement. Example:
//program	user		program	user
//Please choose a type:
//1 --> int
//2 --> double
//3 --> string	3		Please choose a type:
//1 --> int
//2 --> double
//3 --> string	2
//Please enter a string:	hello		Please enter a double:	1.5
//hello*			2.5	


namespace _09PlayINtDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            byte  choise;
            Console.Write("Please choose the input:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            bool isChoise = byte.TryParse(Console.ReadLine(), out choise);

            if (isChoise)
            {
                int myInt;
                double myDouble;

                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Please enter integer digit");
                        bool isInt = int.TryParse(Console.ReadLine(), out myInt);
                        if (isInt)
                        {
                            Console.WriteLine("The result is {0}", (myInt + 1));
                        }
                        else Console.WriteLine("it is not a valid int"); break;
                    case 2:
                        Console.WriteLine("Please enter double digit");
                        bool isD = double.TryParse(Console.ReadLine(), out myDouble);
                        if (isD)
                        {
                            Console.WriteLine("The result is {0}", (myDouble + 1));
                        }
                        else Console.WriteLine("it is not a valid int"); break;
                    case 3:
                        Console.WriteLine("Please enter string");
                        string myString = Console.ReadLine();
                        string new1 = myString + "*";
                            Console.WriteLine("The result is {0}", new1); break;
                }
            }
            else Console.WriteLine("It is not a valid entry");

            Console.ReadLine();
        }
    }
}
