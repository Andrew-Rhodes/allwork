using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //default cons

            MiniVan myVan = new MiniVan();
            Console.WriteLine($"max speed is {myVan.MaxSpeed}");

            MiniVan myVan2 = new MiniVan(75, 0);
            Console.WriteLine($"max speed is {myVan2.MaxSpeed}");

            MiniVan myVan3 = new MiniVan(90);
            Console.WriteLine($"max speed is {myVan3.MaxSpeed}");

            Console.ReadLine();
        }
    }
}
