using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithExceptions
{
    public class MySpeficExpetion : Exception
    {
        public MySpeficExpetion(string message) : base(message)
        {
            HelpLink = "http://www.google.com";
        }

    }
}
