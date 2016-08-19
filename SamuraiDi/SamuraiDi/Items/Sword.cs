using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiDi.Items
{
    public class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine($"chopped {target} clean in half!");
        }
    }
}
