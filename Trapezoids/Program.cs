using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trapezoids
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write the length of the side a of the trapezoid which area to calculate: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the side b of the trapezoid which area to calculate: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Write the length of the side h of the trapezoid which area to calculate: ");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine("The area of the trapezoid with a {0}, b {1} and h {2} is: {3}", a, b, h, h* (a + b) / 2);
        }
    }
}
