using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunWithCollections.Collections;

namespace FunWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            NonGeneric.ShowArrayList();
            Console.WriteLine();

            NonGeneric.ShowHashTable();
            Console.WriteLine();

            NonGeneric.ShowStack();
            Console.WriteLine();

            NonGeneric.ShowQueue();
            Console.WriteLine();

            Generics obj = new Generics();

            obj.ShowStack();
            Console.WriteLine();

            obj.ShowQue();
            Console.WriteLine();

            obj.SimpleList();
            Console.WriteLine();

            obj.PersonDictionary();
            Console.WriteLine();

            Console.ReadLine();


        }
    }
}
