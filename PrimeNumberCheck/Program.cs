using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write integer number to check if it is prime: ");
            int givenInteger = Convert.ToInt32(Console.ReadLine());
            if (givenInteger == 0 || givenInteger == 1)
            {
                Console.WriteLine("{0} is not prime.", givenInteger);
                Console.ReadLine();
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(givenInteger); i++)
                {
                    if (givenInteger % i == 0)
                    {
                        Console.WriteLine("{0} is not prime number.", givenInteger);
                        return;
                    }
                }
                Console.WriteLine("{0} is a prime number.", givenInteger);
            }
        }
    }
}
