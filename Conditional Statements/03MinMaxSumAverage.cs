using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 3.	Min, Max, Sum and Average of N Numbers
//Write a program that reads from the console a sequence of n integer numbers and 
//returns the minimal, the maximal number, the sum and the average of all numbers 
//(displayed with 2 digits after the decimal point). The input starts by the number n 
//(alone in a line) followed by n lines, each holding an integer number. The output is 
//like in the examples below. Examples:
//input	output		input	output
//3      min = 1	    2	   min = -1
//2      max = 5      -1     max = 4
//5      sum = 8       4     sum = 3
//1	   avg = 2.67	      avg = 1.50


namespace _03MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Please enter number n:");
            bool check = int.TryParse(Console.ReadLine(), out n);

            int start = 0;
            int[] numbersArray = new int[n];

            if (check)
            {
                while (start < n)
                {
                    Console.Write("Please enter {0} numbers, each of new line",n);
                    int number = int.Parse(Console.ReadLine());
                    numbersArray[start] = number ;
                    start++;
                }

                //Array.Sort(numbersArray);
                //Array.Reverse(numbersArray);
                int max = numbersArray.Max();
                int min = numbersArray.Min();
                int sum = numbersArray.Sum();
                double aver = numbersArray.Average();

                foreach (int number in numbersArray)
                {
                    Console.WriteLine(number);
                    
                }

                Console.WriteLine("Min = {0} , max = {1}, sum = {2}, average = {3}",min, max, sum, aver);
            }
            else Console.Write("Not a valid input");

            Console.ReadLine();
        }
    }
}
