using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitwiseExtractBit3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write integer number for finding the value of the bit #3 of: ");
            int givenInteger = Convert.ToInt16(Console.ReadLine());
            int position = 3;
            int nRightP = givenInteger >> position;
            int bit = nRightP & 1;
            Console.WriteLine("The the value of the bit #3 of {0} is: {1}", givenInteger, bit);
        }
    }
}
