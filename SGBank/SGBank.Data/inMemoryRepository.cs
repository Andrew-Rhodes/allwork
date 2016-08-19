using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.Models;

namespace SGBank.Data
{
    public class inMemoryRepository : AccountReopsitory
    {
        public inMemoryRepository()
        {
            AccountList.Add(1, new Account() {AccountID = 1, Balance = 1.99m, Name = "Johnny Manziel"});
            AccountList.Add(2, new Account() { AccountID = 2, Balance = 10000000000.00m, Name = "Mark Cuban" });
            AccountList.Add(3, new Account() { AccountID = 3, Balance = 123456789.00m, Name = "Kermit the Frog" });
        }

        public override decimal Close(Account account)
        {
            decimal amount = 0;

            if (AccountList.ContainsKey(account.AccountID))
            {
                AccountList.Remove(account.AccountID);
                amount = account.Balance;
            }
            return amount;
        }

        public override bool Deposit(Account account, decimal amountToDeposit)
        {
            bool isSuccessful = false;

            if (AccountList.ContainsKey(account.AccountID))
            {
                Account currentAccount = AccountList[account.AccountID];
                currentAccount.Balance += amountToDeposit;
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
                isSuccessful = true;
            }

            return isSuccessful;
        }
    }
}
