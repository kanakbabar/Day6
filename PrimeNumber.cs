using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Assignment
{
    class PrimeNumber
    {
        public static void PN()
        {
            Console.WriteLine("Enter a number N");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N == 2)
                Console.WriteLine(+N + "is a prime number");
            else if ((N % 2 == 0) || (N % 3 == 0) || (N % 5 == 0) || (N % 7 == 0))
                Console.WriteLine(+N + "is a not prime number");
            else
                Console.WriteLine(+N + "is a prime number");
        }
    }
}