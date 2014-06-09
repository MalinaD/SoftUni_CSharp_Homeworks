using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 14.	Decimal to Binary Number
//Using loops write a program that converts an integer number to its binary representation. 
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality. Examples:
//decimal	binary
//0	0
//3	11
//43691	1010101010101011
//236476736	1110000110000101100101000000


namespace _14DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Decimal number:");
            int decimNum = Convert.ToInt32(Console.ReadLine());

            string[] stringNum = new string[decimNum];
            int[] temp = new int[decimNum];
            int tempNum;

            for (int i = 0; i < stringNum.Length; i++)
            {
                temp[i] = decimNum % 2;
                tempNum= decimNum / 2;
                stringNum[i] = Convert.ToString(temp[i]);
            }

            //
            // Call the methods.
            //
            string result1 = ConvertStringArrayToString(stringNum);

            //
            // Display the results.
            //
            Console.WriteLine("The Decimal number in Binary system looks like !");
            Console.WriteLine(result1);

            Console.ReadLine();
        }

        static string ConvertStringArrayToString(string[] array)
        {
            //
            // Concatenate all the elements into a StringBuilder.
            //
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                //builder.Append('.');
            }
            return builder.ToString();
        }
    }
}
