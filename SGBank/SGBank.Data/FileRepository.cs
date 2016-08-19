using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.Models;

namespace SGBank.Data
{
    public class FileRepository : AccountReopsitory
    {
        private const string FILENAME = "accounts.txt";

        public FileRepository()
        {
            using (StreamReader sr = File.OpenText(FILENAME))
            {
                string inputLine = "";
                string[] inputParts;
                while ((inputLine = sr.ReadLine()) != null)
                {
                    inputParts = inputLine.Split('|');
                    Account thisAccount = new Account()
                    {
                        AccountID = int.Parse(inputParts[0]),
                        Balance = decimal.Parse(inputParts[1]),
                        Name = inputParts[2]
                    };

                    AccountList.Add(thisAccount.AccountID, thisAccount);
                }
            }
        }

        public override bool Deposit(Account account, decimal amountToDeposit)
        {
            bool isSuccessful = false;
            if (AccountList.ContainsKey(account.AccountID))
            {
                Account currentAccount = AccountList[account.AccountID];
                currentAccount.Balance += amountToDeposit;

                using (StreamWriter sw = new StreamWriter(FILENAME, false))
                {
                    //or var
                    foreach (KeyValuePair<int, Account> a in AccountList)
                    {
                        sw.WriteLine($"{a.Value.AccountID}|{a.Value.Balance}|{a.Value.Name}");
                    }
                }
                isSuccessful = true;
            }
            return isSuccessful;
        }

        public override bool Withdrawl(Account account, decimal amountToWithdrawl)
        {
            bool isSuccessful = false;
            if (AccountList.ContainsKey(account.AccountID))
            {
                Account currentAccount = AccountList[account.AccountID];
                currentAccount.Balance -= amountToWithdrawl;

                using (StreamWriter sw = new StreamWriter(FILENAME, false))
                {
                    //or var
                    foreach (KeyValuePair<int, Account> a in AccountList)
                    {
                        sw.WriteLine($"{a.Value.AccountID}|{a.Value.Balance}|{a.Value.Name}");
                    }
                }
                isSuccessful = true;
            }
            return isSuccessful;
        }

        public override decimal Close(Account account)
        {
            decimal amount = 0;

            if (AccountList.ContainsKey(account.AccountID))
            {
                AccountList.Remove(account.AccountID);

                using (StreamWriter sw = new StreamWriter(FILENAME, false))
                {
                    //or var
                    foreach (KeyValuePair<int, Account> a in AccountList)
                    {
                        sw.WriteLine($"{a.Value.AccountID}|{a.Value.Balance}|{a.Value.Name}");
                    }
                }

                amount = account.Balance;
            }
            return amount;
        }
    }
}
