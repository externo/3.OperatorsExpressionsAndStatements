using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtractBitFromInteger
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write integer number for finding the value of the bit #n of: ");
            int givenInteger = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Write position of the bit #n to extract from the integer {0}: ", givenInteger);
            int position = Convert.ToInt16(Console.ReadLine());
            int nRightP = givenInteger >> position;
            int bit = nRightP & 1;
            Console.WriteLine("The the value of the bit #{0} of {1} is: {2}", position, givenInteger, bit);
        }
    }
}
