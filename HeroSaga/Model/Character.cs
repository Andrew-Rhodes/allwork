using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Character
    {
        public int Id { get; set; }
        public string RaceId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public Alignment Alignment { get; set; }

        public virtual Race Race { get; set; }
        public virtual List<Battle> Battles { get; set; }
    }
}
