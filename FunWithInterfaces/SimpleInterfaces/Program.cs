using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            GermanSheppard bigDog = new GermanSheppard();
            Console.WriteLine(bigDog.GoForAWalk());
            bigDog.Bark();

            bigDog.Name = "Gambit";
            Console.WriteLine(bigDog.Name);

            Console.WriteLine();

            Chiuawawa smallDog = new Chiuawawa("Taco Bell");
            Console.WriteLine(smallDog.GoForAWalk());
            smallDog.Bark();

            //smallDog.Name = "Gambit"; cannot set public, private set.
            Console.WriteLine(smallDog.Name);


            Console.ReadLine();
        }
    }
}
