using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GravitationOnTheMoon
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write weight of a man on Earth: ");
            float weightOnEarth = float.Parse(Console.ReadLine());
            Console.WriteLine("The man with weight {0} on Earth has weight {1} on the moon.", weightOnEarth, 0.17 * weightOnEarth);
        }
    }
}
