using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praticeStuff
{
    public class myMethod
    {
        public string CurrentDayandTime()
        {
            DateTime theDate = DateTime.Now;

            if (theDate.Day == 14 && theDate.Month == 6)
            {

                return "today Sucked";
            }
            return theDate.ToString("yy-MM-dd");

        }

        public int CalcArea(int a, int b)
        {
            int area = a*b;

            return area;
        }

        public void PrintAverage(params int[] nums)
        {
            double sum = 0;
            int count = 0;

            foreach (int num in nums)
            {
                sum += num;
                count += 1;
            }

            Console.WriteLine("The Average is {0}", sum/count);
        }




    }
}
