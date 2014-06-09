using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 10.	Odd and Even Product
//You are given n integers (given in a single line, separated by a space). 
//Write a program that checks whether the product of the odd elements is equal 
//to the product of the even elements. 




namespace _10OddEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Please enter number n");
            bool isIntN = int.TryParse(Console.ReadLine(), out n);

            int odd_product=1, even_product=1;
            int sum_odd = 0,sum_even=0;

            if(isIntN)
            {

            Console.WriteLine("Please add {0} integers on one line separated by space ",n);
            string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] myArray = new int[n];

            for (int i = 0; i < n;i++ )
            {
                myArray[i] = Convert.ToInt32(tokens[i]);
                Console.WriteLine(myArray[i]);
            }

            foreach (int value in myArray)
            {
                if(value%2==0)
                {
                    sum_odd += value;
                    odd_product *= value;
                }
                else
                {
                    sum_even += value;
                    even_product *= value;
                }
                
            }

            if (odd_product == even_product)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + odd_product);
                Console.WriteLine("sum of odd = " + sum_odd);
                Console.WriteLine("sum of even = " + sum_even);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = " + odd_product);
                Console.WriteLine("even_product = " + even_product);
                Console.WriteLine("sum of odd = " + sum_odd);
                Console.WriteLine("sum of even = " + sum_even);
            }           

            }
            else Console.WriteLine("Not a valid digit");

            Console.ReadLine();
        }
    }
}
