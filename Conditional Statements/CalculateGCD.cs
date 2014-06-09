using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int remain = a % b;
            while (remain != 0)
            {
                a = b;
                b = remain;
                remain = a % b;
            }
            Console.WriteLine(Math.Abs(b));

            Console.ReadLine();
        }
    }
}
