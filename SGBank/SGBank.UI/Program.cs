using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.BLL;
using SGBank.Models;

namespace SGBank.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleIO start = new ConsoleIO();

            bool nextTransaction = false;
            do
            {
                start.WelcomeMenu();
                int selection = start.SelectionValidation();

                nextTransaction = start.selectionSwitch(selection);




            } while (nextTransaction == true);
             


            //AccountOperations test = new AccountOperations();

            //test.MakeDeposit(1, 5);

            //Console.WriteLine();

            //Console.ReadLine();

            //var list = test.ListOfAccounts();

            //foreach (var i in list)
            //{
            //    Console.WriteLine($"{i.Value.AccountID} {i.Value.Balance} {i.Value.Name} {i.Key}");
            //}

            Console.ReadLine();


        }
    }
}
