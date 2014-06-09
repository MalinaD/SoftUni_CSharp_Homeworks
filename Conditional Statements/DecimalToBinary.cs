using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            int modulRest;
            string binary = "";
            if (decimalNumber == 0)
            {
                Console.WriteLine(decimalNumber);
            }
            else
            {
                while (decimalNumber > 0)
                {
                    modulRest = decimalNumber % 2;
                    decimalNumber = decimalNumber / 2;
                    binary = modulRest.ToString() + binary;
                }
                Console.WriteLine(binary);
            }
            Console.ReadLine();
        }
    }
}
