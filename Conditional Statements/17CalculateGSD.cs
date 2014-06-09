using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Calculate GCD
//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. 
//Use the Euclidean algorithm (find it in Internet).
//two or more integers (at least one of which is not zero), is the largest positive integer that 
//divides the numbers without a remainder. For example, the GCD of 8 and 12 is 4.
//Examples:
//a	b	GCD(a, b)
//3	2	1
//60	40	20
//5	-15	5


namespace _17CalculateGSD
{
    class Program
    {
        public static int[] GetFactors(int numberToCheck)
        {
            // we know 1 is a factor and the numberToCheck
           // int factorCount = 2;
            int[] divisors = new int[numberToCheck];
            // start from 2 as we know 1 is a factor, and less than as numberToCheck is a factor
            for (int i = 2; i < numberToCheck; i++)
            {
                if (numberToCheck % i == 0)
                   // factorCount++;
                    divisors[i] = i;
            }
            return divisors;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int[] arrayA = GetFactors(a);
            int[] arrayB = GetFactors(b);

            Array.Sort(arrayA);
            Array.Sort(arrayB);

            //int firstNumber = arrayA.Last();
            //int secondNumber = arrayB.Last();
            int firstNumber = a;
            int secondNumber = b;
            int GCD, temp;

            if (firstNumber > secondNumber)
            {
                temp = secondNumber;
                secondNumber = firstNumber;
                firstNumber = temp;

            }

            while (secondNumber != 0)
            {
                GCD = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = GCD;
                Console.WriteLine(GCD);
            }

            

            Console.ReadLine();
        }
    }
}
