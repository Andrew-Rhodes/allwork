using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWednesdays.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            //prompt for date
            string dateString = prog.DisplayPrompt("Please enter the date you wish to start with: ");
            DateTime startDate = DateTime.Parse(dateString);

            //prompt for the number of wednesdays
            string numWedString = prog.DisplayPrompt("How many of Wednesdays do you want: ");
            int numWed = int.Parse(numWedString);

            startDate = prog.GetNextWed(startDate);




            //loop for number of of wed and print
            for (int i = 0; i < numWed; i++)
            {
                Console.WriteLine(startDate.ToShortDateString());
                Console.WriteLine(startDate.ToLongDateString());
                Console.WriteLine();

                startDate = startDate.AddDays(7);
            }
            Console.ReadLine();
        }


        public string DisplayPrompt(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public DateTime GetNextWed(DateTime date)
        {
            //loop until we are sure we are on the frist wednesday
            while (date.DayOfWeek != DayOfWeek.Wednesday)
            {
                date = date.AddDays(1);
            }

            return date;
        }
    }
}

