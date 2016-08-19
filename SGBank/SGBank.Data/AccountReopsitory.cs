using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.Models;

namespace SGBank.Data
{
    public abstract class AccountReopsitory
    {
        public virtual Dictionary<int, Account> AccountList { get; private set; }



        /// <summary>
        /// default constructor that initializes out account list
        /// </summary>
        public AccountReopsitory()
        {
            AccountList = new Dictionary<int, Account>();
        }




        /// <summary>
        /// deposit into the acount the amount given
        /// </summary>
        /// <param name="account">where to put money</param>
        /// <param name="amountToDeposit">$$$$$$$</param>
        /// <returns>if it worked</returns>
        public abstract bool Deposit(Account account, decimal amountToDeposit);

        /// <summary>
        /// amount and acount to withdrawl
        /// </summary>
        /// <param name="account">acount to withdraqul form </param>
        /// <param name="amountToWithdrawl">$$$$$$$$$$$$</param>
        /// <returns>bool of if it worked</returns>
        public abstract bool Withdrawl(Account account, decimal amountToWithdrawl);

        /// <summary>
        /// account to close
        /// </summary>
        /// <param name="account">account to end</param>
        /// <returns>any remaining amout in the closed acount</returns>
        public abstract decimal Close(Account account);
    }
}
