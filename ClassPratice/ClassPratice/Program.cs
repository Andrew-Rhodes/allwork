using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            double trypi = Math.PI;

            int[] PiArray = new int[3];

            string pistring = trypi.ToString();




            for (int i = 0; i < PiArray.Length; i++)
            {
                string singleInt = pistring.Substring(i, 1);


                int singlePi = 0;
                int parsed = 0;
                if (int.TryParse(singleInt out parsed))
                {
                PiArray[i] = singlePi;
                    
                }
            else
                {
                    PiArray[i] = singleInt
                }

            }

            foreach (var i in PiArray)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine(trypi);

            Console.ReadLine();

        }
    }
}
