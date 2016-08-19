using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SystemDotObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a POint and write it out
            Point p1 = new Point(7, 17);
            Console.WriteLine(p1);

            //creat3e   a new point and compare
            Point p2 = new Point(7, 17);
            Console.WriteLine(object.Equals(p1,  p2));
            Console.WriteLine(object.ReferenceEquals(p1, p2));

            //use copy method and create a new point and compare
            Point p3 = p1.copy();
            Console.WriteLine(object.Equals(p1, p2));
            Console.WriteLine(object.ReferenceEquals(p1, p2));

            Console.ReadLine();

        }
    }
}
