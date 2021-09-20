using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Assignment
{
    class FibonaciiSeries
    {
        public static void Fs()
        {

            Console.WriteLine("Enter a number :");
            int n;
            n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int i = 2;

            while (i < n)
            {
                i = i + 1;
                   
                int c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}