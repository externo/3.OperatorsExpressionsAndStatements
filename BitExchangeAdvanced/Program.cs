using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitExchangeAdvanced
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("A program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap.");
            Console.WriteLine("Write k: ");
            int k = Convert.ToInt16(Console.ReadLine());
            int b = 0;
            for (uint i = 0; i < k; i++)
            {
                b += (int)Math.Pow(2, i);
            }
            uint basicMask = (uint)Math.Round((double)b, 0);
            Console.WriteLine("Write p: ");
            int p = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Write q: ");
            int q = Convert.ToInt16(Console.ReadLine());
            if (Math.Abs(p - q) < k)
            {
                Console.WriteLine("The result is overlapping.");
            }
            else if (p < 0 || q < 0 || k < 0 || (Math.Abs(p-q) + k > 31))
            {
                Console.WriteLine("The result is out of range.");
            }
            else
            {
                Console.WriteLine("basicMask for 3 bits to change" + Convert.ToString(basicMask, 2).PadLeft(32, '0'));
                uint basicMaskLeft = basicMask << q;
                Console.WriteLine("basicMaskLeft on 24,25,26 pos:" + Convert.ToString(basicMaskLeft, 2).PadLeft(32, '0'));
                uint basicMaskRight = basicMask << p;
                Console.WriteLine("basicMaskRight on 3,4,5 pos:  " + Convert.ToString(basicMaskRight, 2).PadLeft(32, '0'));
                uint mask = basicMaskLeft | basicMaskRight;
                Console.WriteLine("mask                          " + Convert.ToString(mask, 2).PadLeft(32, '0'));
                Console.WriteLine("Write unsigned integer to change its bits: ");
                uint givenInteger = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("giveninteger as binary number:" + Convert.ToString(givenInteger, 2).PadLeft(32, '0'));
                uint bitsToChange = givenInteger & mask;
                Console.WriteLine("bitsToChange                  " + Convert.ToString(bitsToChange, 2).PadLeft(32, '0'));
                uint leftBitsToRight = bitsToChange << 32 - q - k >> 32 - k << p;
                Console.WriteLine("leftBitsToRight               " + Convert.ToString(leftBitsToRight, 2).PadLeft(32, '0'));
                uint rightBitsToLeft = bitsToChange << 32 - p - k >> 32 - k << q;
                Console.WriteLine("rightBitsToLeft               " + Convert.ToString(rightBitsToLeft, 2).PadLeft(32, '0'));
                uint newMask = leftBitsToRight | rightBitsToLeft;
                Console.WriteLine("newMask =                     " + Convert.ToString(newMask, 2).PadLeft(32, '0'));
                uint exchangedInteger = givenInteger ^ bitsToChange | newMask;
                Console.WriteLine("Integer {0} with exchange bits on [{1}, {1}+1, …, {1}+{3}-1] with bits [{2}, {2}+1, …, {2}+{3}-1] is {4}: ",
                givenInteger, p, q, k, exchangedInteger);
                Console.WriteLine("The binary result is: " + Convert.ToString(exchangedInteger, 2).PadLeft(32, '0'));
            }
        }
    }
}
