using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICompareableExample
{
    public class Temperature : IComparable
    {
        public double fahrenheight { get; set; }
        public double celsius { get { return (fahrenheight - 32)*(5.0/9); } }

        public int CompareTo(object obj)
        {
            var otherTemp = obj as Temperature;

            if (otherTemp != null)
            {
                if (this.fahrenheight < otherTemp.fahrenheight)
                {
                    return -1;
                }
                else if (this.fahrenheight == otherTemp.fahrenheight)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                throw new ArgumentException("object is not a temperature");
            }
        }
    }
}
