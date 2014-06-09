using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitsExchange
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("A program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.");
            uint basicMask = 7;
            Console.WriteLine("basicMask for 3 bits to change" + Convert.ToString(basicMask, 2).PadLeft(32, '0'));
            uint basicMaskLeft = basicMask << 24;
            Console.WriteLine("basicMaskLeft on 24,25,26 pos:" + Convert.ToString(basicMaskLeft, 2).PadLeft(32, '0'));
            uint basicMaskRight = basicMask << 3;
            Console.WriteLine("basicMaskRight on 3,4,5 pos:  " + Convert.ToString(basicMaskRight, 2).PadLeft(32, '0'));
            uint mask = basicMaskLeft | basicMaskRight;
            Console.WriteLine("mask                          " + Convert.ToString(mask, 2).PadLeft(32, '0'));
            Console.WriteLine("Write unsigned integer to change its bits: ");
            uint givenInteger = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("giveninteger as binary number:" + Convert.ToString(givenInteger, 2).PadLeft(32, '0'));
            uint bitsToChange = givenInteger & mask;
            Console.WriteLine("bitsToChange                  " + Convert.ToString(bitsToChange, 2).PadLeft(32, '0'));
            uint leftBitsToRight = bitsToChange << 5 >> 26;
            Console.WriteLine("leftBitsToRight               " + Convert.ToString(leftBitsToRight, 2).PadLeft(32, '0'));
            uint rightBitsToLeft = bitsToChange >> 3 << 24;
            Console.WriteLine("rightBitsToLeft               " + Convert.ToString(rightBitsToLeft, 2).PadLeft(32, '0'));
            uint newMask = leftBitsToRight | rightBitsToLeft;
            Console.WriteLine("newMask =                     " + Convert.ToString(newMask, 2).PadLeft(32, '0'));
            uint exchangedInteger = givenInteger ^ bitsToChange | newMask;
            Console.WriteLine("Integer {0} with exchange bits on 3, 4, 5 position with these on 24, 25, 26 position is {1}: ", 
                givenInteger, exchangedInteger);
        }
    }
}
