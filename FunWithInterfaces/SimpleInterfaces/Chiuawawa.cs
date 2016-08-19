using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaces
{
    public class Chiuawawa : Idog
    {
        public string Name { get; private set; }

        public Chiuawawa(string name)
        {
            Name = name;
        }

        public void Bark()
        {
            Console.WriteLine("yip");
                
        }

        public string GoForAWalk()
        {
            return "goin for a short walk";
        }
    }
}
