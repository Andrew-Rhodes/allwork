using System.Collections.Generic;

namespace Model
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Battle> Battles { get; set; }
    }
}