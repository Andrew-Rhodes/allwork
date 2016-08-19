using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICompareableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperatures = new Temperature[]
            {
                new Temperature() {fahrenheight = 71},
                new Temperature() {fahrenheight = 120},
                new Temperature() {fahrenheight = 75},
                new Temperature() {fahrenheight = 60}

            };



            Array.Sort(temperatures);

            foreach (var temp in temperatures)
            {
                Console.WriteLine($"{temp.fahrenheight} {temp.celsius}");
            }

            Console.ReadLine();
        }
    }
}
