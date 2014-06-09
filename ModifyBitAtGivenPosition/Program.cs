using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModifyBitAtGivenPosition
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write value 0 or 1 to set the value of the bit #n with: ");
            int value = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Write integer number to set the value of the bit #n with {0}: ", value);
            int givenInteger = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("From the integer {0} write position of the bit #n  to set it with value {1}: ", givenInteger, value);
            int position = Convert.ToInt16(Console.ReadLine());
            int newInteger;
            if (value == 0)
            {
                int mask = ~(1 << position);
                int result = givenInteger & mask;
                newInteger = result;
            }
            else
            {
                int mask = 1 << position;
                int result = givenInteger | mask;
                newInteger = result;
            }
            Console.WriteLine("The given integer {0} is modified in new integer {1}", givenInteger, newInteger);
        }
    }
}
