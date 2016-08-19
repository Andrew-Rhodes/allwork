using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.BLL;

namespace SGBank.UI
{
    public class ConsoleIO
    {
     
      
           
        public void WelcomeMenu()
        {
            Console.WriteLine("Welcome to SWG Bank");
            Console.WriteLine();
            Console.WriteLine("Select an option");
            Console.WriteLine();
            Console.WriteLine("1 : Deposit");
            Console.WriteLine("2 : Withdrawl");
            Console.WriteLine("3 : Transfer");
            Console.WriteLine();
        }

        public int SelectionValidation()
        {
            bool selectionValid = true;
            int parsedSelection;
            do
            {
                string choice = Console.ReadLine();
                
                if ((!int.TryParse(choice, out parsedSelection) || (parsedSelection > 3) || (parsedSelection < 1)))
                {
                    selectionValid = false;
                    Console.WriteLine("please make a valid selection");
                }
                else
                {
                selectionValid = true;
                }

            } while (selectionValid == false);

            return parsedSelection;
        }


        public bool selectionSwitch(int selection)
        {
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Deposit");
                    DepositCall();
                    break;

                case 2:
                    Console.WriteLine("Withdrawl : Feature Unavailble");
                    return true;
                    break;

                case 3:
                    Console.WriteLine("Transfer : Feature Unavailable");
                    return true;
                    
                    break;

                default:
                    Console.WriteLine("Stop trying to break my code!");
                    return true;
                    break;
            }
            return true;
        }

        private void DepositCall()
        {
            AccountOperations CallBLL = new AccountOperations();

            Console.WriteLine("What Account are you depositing to?");

            int accountNumber = SelectionValidation();

            Console.WriteLine("How much are you going to deposit?");

            decimal depositAmount = DepositValidationAndConversion();

            CallBLL.MakeDeposit(accountNumber, depositAmount);


        }


        private decimal DepositValidationAndConversion()
        {
            bool selectionValid = true;
            decimal parsedSelection = 0;
            do
            {
                string choice = Console.ReadLine();

                if (!decimal.TryParse(choice, out parsedSelection) || (parsedSelection < 0))
                {
                    selectionValid = false;
                    Console.WriteLine("please make a valid selection");
                }
                else
                {
                    selectionValid = true;
                }


            } while (selectionValid == false);

            return parsedSelection;
        }

    }
}
