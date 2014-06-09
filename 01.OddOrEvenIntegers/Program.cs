using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddOrEvenIntegers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write integer number to check if it is Odd: ");
            int givenInteger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer of the question \"If the given integer is Odd?\" is: {0}", Math.Abs(givenInteger)%2 != 0);
        }
    }
}
