using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirdDigitIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write integer number to check if its third digit is 7: ");
            int givenInteger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer of the question \"If the third digit of the given integer is 7?\" is: {0}", (Math.Abs(givenInteger) / 100) % 10 ==7);
        }
    }
}
