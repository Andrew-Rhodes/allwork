using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaces
{
    public class GermanSheppard : Idog
    { 
        public string Name { get; set; }

        public void Bark()
        {
            Console.WriteLine("Woof");
        }

        public string GoForAWalk()
        {
            return "Going for a long walk";
        }
    }
}
