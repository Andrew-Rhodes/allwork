using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCollections.Collections
{
    public class NonGeneric
    {
        public static void ShowArrayList()
        {
            Console.WriteLine("<= Show ArrayList");

            ArrayList arraryList = new ArrayList();

            arraryList.Add("Hello");
            arraryList.Add(17);

            person p = new person();
            p.FirstName = "Andy";
            p.LastName = "Rhodes";

            arraryList.Add(p);
            foreach (var i in arraryList)
            {
                Console.WriteLine(i);
            }

        }

        public static void ShowHashTable()
        {
            Console.WriteLine("<= hashtable");
         
            Hashtable map = new Hashtable();
            
            map.Add(1, "Hello");  
            map.Add("world", 2);
            map.Add(true, 123.456);

            person bart = new person();
            bart.FirstName = "Bart";
            bart.LastName = "Simpson";

            map.Add(bart.LastName, bart);

            foreach (var key in map.Keys)
            {
                Console.WriteLine($"{key} = {map[key]}");
            }
        }

        public static void ShowStack()
        {
            Console.WriteLine("<= show stack");

            Stack myStack = new Stack();

            myStack.Push("Hello");
            myStack.Push(123);

            person kyrie = new person();
            kyrie.FirstName = "kyrie";
            kyrie.LastName = "Irving";

            myStack.Push(kyrie);

            int count = myStack.Count;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myStack.Pop());
            }
        }

        public static void ShowQueue()
        {
            Console.WriteLine("<= show Queue");

            Queue myQueue = new Queue();

            myQueue.Enqueue("Hello");
            myQueue.Enqueue(123);

            person kyrie = new person();
            kyrie.FirstName = "kyrie";
            kyrie.LastName = "Irving";

            myQueue.Enqueue(kyrie);

            int count = myQueue.Count;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }

        }
    }
}

