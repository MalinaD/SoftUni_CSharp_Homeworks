using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Problem 13.	Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form. 
//The input is entered as string. The output should be a variable of type long. 
//Do not use the built-in .NET functionality. Examples:
//binary	decimal
//0	0
//11	3
//1010101010101011	43691
//1110000110000101100101000000	236476736


namespace _13BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter binary number");
            string binary = Console.ReadLine();

            //int number = Convert.ToInt32(binary, 2).ToString();

            int length = binary.Length;
            double numDecimal = 0;
            double multiplier = 1;
            //char[] b = new char[binary.Length];
            double[] numbersDecimal = new double[length];
            byte[] temp = new byte[length];

            //other way to split the characters
            //foreach (char c in binary)
            //{
            //    Console.WriteLine(c);
           // }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(binary[i]);
                Console.WriteLine();


                if(!(binary[i]==0)||!(binary[i]==1))
                {
                    temp[i] = byte.Parse(Convert.ToString((binary[i])));       
                }
                else Console.WriteLine("It is not a valid entry");

                numbersDecimal[i] = temp[i] * ((long)Math.Pow(2, i));
                Console.WriteLine(numbersDecimal[i]);
            }

            //foreach (var digit in binary)
            //{
           //     numDecimal += (digit * multiplier);
           //     multiplier *= 2;
           // }

            //Console.WriteLine(numDecimal);
            Console.ReadLine();
        }
    }
}
