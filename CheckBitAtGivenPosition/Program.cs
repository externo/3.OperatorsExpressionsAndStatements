using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckBitAtGivenPosition
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write integer number to check the value of the bit #n of: ");
            int givenInteger = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Write position of the bit #n from the integer {0} to check the value from : ", givenInteger);
            int position = Convert.ToInt16(Console.ReadLine());
            int nRightP = givenInteger >> position;
            int bit = nRightP & 1;
            bool hasValue1 = bit == 1;
            Console.WriteLine("The answer of the question \"Does the bit #{0} of {1} have value 1 ?\" is: {2}",
                bit, givenInteger, hasValue1);
        }
    }
}
