using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Number as Words
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
//numbers	number as words
//0	Zero
//9	Nine
//10	Ten
//12	Twelve
//19	Nineteen
//25	Twenty five
//98	Ninety eight
//273	Two hundred and seventy three
//400	Four hundred
//501	Five hundred and one
//617	Six hundred and seventeen
//711	Seven hundred and eleven
//999	Nine hundred and ninety nine


namespace _11NumberAsWords
{
    class Program
    {
        static string[] arr = { "zero", "one", "two", "three", "four", "five", "six","seven", "eight" , "nine",
                                  "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                                  "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", 
                                  "eighty", "ninety", "hundred" };
        static void Main(string[] args)
        {
            ushort number;
            Console.WriteLine("Please enter integer digit");
            bool isInt = ushort.TryParse(Console.ReadLine(), out number);
            if (isInt)
            {
                if (number > 99&& number <1000) 
                {
                Console.WriteLine((double)number/(number%1000/100)==100? arr[number%1000/100]+" "+arr[arr.Length-1] :arr[number%1000/100]+" "+arr[arr.Length-1]+" "+ (number%100/10==0? "and"+" "+ arr[number%10] : (number%100<21?"and " + arr[(number%100)] : "and " + arr[18+(number%100/10)] + " " + (number%10!=0? arr[number%10] : " "))));
            }
            else if (number < 100) 
                {
                Console.WriteLine(number % 100 / 10 == 0 ? arr[number % 10] : (number <21 ? arr[number] : arr[18 + (number % 100 / 10)] + " " + (number % 10 != 0 ? arr[number % 10] : " "))); 
            }
  
            }
            else Console.WriteLine("it is not a valid int");

            Console.ReadLine();
        }
    }
}
