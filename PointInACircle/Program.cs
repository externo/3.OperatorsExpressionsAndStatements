using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointInACircle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write x of the point (x, y) to check if it is inside a circle K([0, 0], 2): ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Write y of the point ({0}, y) to check if it is inside a circle K([0, 0], 2): ", x);
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(x * x + y * y);
            Console.WriteLine("The answer of the question \"If given point ({0},{1}) is inside a circle K([0, 0], 2)\" is: '{2}'",
                x, y, distance <= 2);
            Console.WriteLine(x/y);
        }
    }
}
