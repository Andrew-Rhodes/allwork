using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskingAndBase
{
    public class DerivedClass : BaseClass
    {
        //masking the base firls
        public new string Field1 = "Derived class Field1";

        public void PringField1()
        {
            Console.WriteLine(Field1);

            Console.WriteLine(base.Field1);
        }
    }
}
