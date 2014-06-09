using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write four digit number to perform it: ");
            int givenInteger = Convert.ToInt32(Console.ReadLine());
            int a = givenInteger / 1000;
            int b = givenInteger % 1000 / 100;
            int c = givenInteger % 100 / 10;
            int d = givenInteger % 10;
            Console.WriteLine("Calculates the sum of the digits: {0}", a + b + c + d);
            Console.WriteLine("Prints on the console the number in reversed order: {0}", 1000 * d + 100 * c + 10 * b + a);
            Console.WriteLine("Puts the last digit in the first position: {0}", 1000 * d + 100 * a + 10 * b + c);
            Console.WriteLine("Exchanges the second and the third digits: {0}", 1000 * a + 100 * c + 10 * b + d);
        }
    }
}
