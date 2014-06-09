using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangles
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write the width of the rectangle which perimeter and area to calculate: ");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Write the height of the rectangle which perimeter and area to calculate: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter of the rectangle with width {0} and height {1} is {2} and his area is {3}",
                width, height, 2*(width+height), width*height);
        }
    }
}
