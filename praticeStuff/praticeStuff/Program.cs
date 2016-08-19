using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace praticeStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            myMethod obj = new myMethod();

            string dateRespones = obj.CurrentDayandTime();

            Console.WriteLine(dateRespones);
            Console.WriteLine();

            int calculatedArea = obj.CalcArea(10, 10);


            Console.WriteLine(calculatedArea);

            Console.WriteLine();

            Console.WriteLine(CalcAreastatic(5, 5) + "static");

            Console.WriteLine();

            obj.PrintAverage(12, 34, 203);

            Console.WriteLine();
            

            
        Console.ReadLine();
        }

        public static int CalcAreastatic(int a, int b)
        {
            int area = a * b;

            return area;
        }

        }
    }

