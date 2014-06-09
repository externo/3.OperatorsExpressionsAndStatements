using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointInsideCircleOutsideOfRectangle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write x of the point (x, y) to check if it is within the circle K([1, 1], 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Write y of the point ({0}, y) to check if it is within the circle K([1, 1], 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).", x);
            float y = float.Parse(Console.ReadLine());
            double distanceToCircleCenter = Math.Sqrt((x-1) * (x-1) + (y-1) * (y-1));
            bool inCircle = (distanceToCircleCenter <= 1.5);
            bool inRectangle = (-1 <= x && x <= 5) && (-1 <= y && y <= 1);
            Console.WriteLine(distanceToCircleCenter);
            Console.WriteLine(inCircle);
            Console.WriteLine(inRectangle);
            Console.WriteLine("The answer of the question \"Is the given point ({0}, {1}) is within the circle K([1, 1], 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2) ?\" is: {2}",
                x, y, inCircle & !inRectangle);
        }
    }
}
