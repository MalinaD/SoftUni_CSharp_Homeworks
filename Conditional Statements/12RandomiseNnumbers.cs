using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 


namespace _12RandomiseNnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Please enter number n");
            bool isIntN = int.TryParse(Console.ReadLine(), out n);

            if (isIntN)
            {
                int[] number = new int[n];
                Random random = new Random();

                for (int i = 0; i < n; i++)
                {
                    Console.Write(random.Next(1, n + 1) + " ");

                }
            }
            else Console.WriteLine("It is not a valid entry");
        }
    }
}
