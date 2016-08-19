using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCollections.Collections
{
    public class Generics
    {
        public void ShowStack()
        {

            Console.WriteLine("<= Generic ShowStack");

            Stack<person> people = new Stack<person>();

            people.Push(new person() { FirstName = "bart", LastName = "Simpson" });
            person simpson;

            int count = people.Count;
            for (int i = 0; i < count; i++)
            {
                simpson = people.Pop();

                Console.WriteLine($"{simpson.FirstName} {simpson.LastName}");
            }
        }

        public void ShowQue()
        {
            Console.WriteLine("<= Generic ShowQueue");

            Queue<person> people = new Queue<person>();

            people.Enqueue(new person() {FirstName = "bart", LastName = "Simpson"});

            int count = people.Count;
            person simpson;
            for (int i = 0; i < count; i++)
            {
                simpson = people.Dequeue();

                Console.WriteLine($"{simpson.FirstName} {simpson.LastName}");
            }
        }

        public void SimpleList()
        {
            Console.WriteLine("<=show List");

            List<int> numbers = new List<int>();

            numbers.Add(1);

            numbers.AddRange(new int[] {5, 4, 3, 2});

            numbers.Insert(2, 100);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            numbers.Remove(4);

            numbers.RemoveRange(0, 2);

            numbers.RemoveAt(0);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


        }

        public void PersonDictionary()
        {
            Console.WriteLine("<=person dic");

            Dictionary<string, person> people = new Dictionary<string, person>();

            person Kyrie = new person() {FirstName = "kyrie", LastName = "irving"};
            person tim = new person() { FirstName = "tim", LastName = "smith" };

            people.Add(Kyrie.LastName, Kyrie);
            people.Add(tim.LastName, tim);

            foreach (var person in people)
            {
             Console.WriteLine($"{person.Value.FirstName} {person.Key}");   
            }

            Console.WriteLine($"{people["smith"].FirstName}");


        }


    }
}

