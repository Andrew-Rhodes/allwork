using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SGBank.Data;
using SGBank.Models;

namespace SGBank.BLL
{
    public class AccountOperations
    {
        public Dictionary<int, Account> ListOfAccounts()
        {
            var list = AccountRepositoryFactory.CreateAccountReopsitory().AccountList;

            return list;
        }


        public bool MakeDeposit(int accountNumber, decimal amountToDeposit)
        {
            var repo = AccountRepositoryFactory.CreateAccountReopsitory();
            Account test = new Account();

            test.AccountID = accountNumber;

            if (amountToDeposit < 0)
            {
                return false;
            }


            var findAccount = ListOfAccounts();

            findAccount.ContainsKey(accountNumber);

            for (var i = 1; i < accountNumber; i++)
            {
                if (findAccount.ContainsKey(accountNumber))
                {
                    
                        repo.Deposit(test, amountToDeposit);
                }
            }
            Console.WriteLine(test.Balance);
            return true;

        }
    }
}

