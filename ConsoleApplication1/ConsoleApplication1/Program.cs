using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now.AddDays(-1);
            Console.WriteLine(now);

            Console.ReadLine();
        }
    }
}
