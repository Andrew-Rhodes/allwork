using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Randall
{
    public class StringCalc
    {
        public int Add(string passed)
        {
            char newDelim = ',';
            int sum = 0;
            if (passed == "")
            {
                return 0;
            }
            else
            {
                if (passed.Substring(0, 2) == "//")
                {
                    newDelim = passed.Substring(2, 1)[0];
                    passed = passed.Substring(4);

                }




                string[] values = passed.Split(',', '\n', newDelim);
                foreach (var value in values)
                {
                    int number = int.Parse(value);
                    sum += number;

                }
            }
            return sum;
        }
    }
}
