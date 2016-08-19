using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDotObject
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        //only constustor for this oblect
        public Point(int x, int y )
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"point as ({x} {y})";
        }

        //allow us to determind the comparison
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Point otherpPoint = (Point) obj;

            return (this.x == otherpPoint.x) && (this.y == otherpPoint.y);

        }

        //we can do a momberwise copy
        //ctreate a new object and copy the values
        public Point copy()
        {
            return (Point) this.MemberwiseClone();
        }

    }
}
