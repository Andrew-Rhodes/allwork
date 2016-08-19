using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 150; i++)
            {
                if ((i%3 == 0) && (i%5 == 0))
                {
                    Console.WriteLine("{0} FizzBuzz", i);
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine("{0} Fizz", i);
                }
                else if (i%5 == 0)
                {
                    Console.WriteLine("{0} Buzz", i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
