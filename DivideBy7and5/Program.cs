using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivideBy7and5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write integer which will be checked if it can be devided by 7 and 5 in the same time: ");
            int givenInteger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer of the question \"If the given integer can be devided by 7 and 5 in the same time?\" is: {0}",
                givenInteger != 0 && givenInteger % 5 == 0 && givenInteger % 7 == 0);
        }
    }
}
