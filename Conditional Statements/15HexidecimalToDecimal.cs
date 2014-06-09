using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15HexidecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexidecimal = Console.ReadLine();
            //int i = Convert.ToInt32(hexidecimal, 16);

            byte[] binarics = new byte[hexidecimal.Length];
            for (int i = 0; i < hexidecimal.Length; i++)
            {
                binarics[i] = byte.Parse(Convert.ToString((hexidecimal[i])));
            }
            Array.Reverse(binarics);

            long numDecimal = 0;
            long multiplier = 1;
            foreach (var digit in binarics)
            {
                numDecimal += (digit * multiplier);
                multiplier *= 16;
            }

            Console.WriteLine("The Hex number in Decimal system looks like DECIMAL = {0} !",
                numDecimal);

            //opposite
            //int i = 255;
            //Console.Write(i.ToString("x")); // ff
            //Console.Write(i); 

            Console.ReadLine();
        }
    }
}
