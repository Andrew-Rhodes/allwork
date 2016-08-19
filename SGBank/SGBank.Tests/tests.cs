using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SGBank.Data;
using SGBank.Models;

namespace SGBank.Tests
{
    [TestFixture]
    class tests
    {
        [Test]
        public void GetAccountes()
        {
            AccountReopsitory repo = AccountRepositoryFactory.CreateAccountReopsitory();

            Assert.AreEqual(3, repo.AccountList.Count);

            foreach (var account in repo.AccountList)
            {
                Console.WriteLine($"{account.Value.AccountID} {account.Value.Name} {account.Value.Balance}");
            }
        }


        [TestCase("Johnny Manziel", 0.00, true)]
        [TestCase("Johnny Manziel", 5.00, true)]
        [TestCase("Johnny Manziel", -2.00, false)]
        public void DepositTests(Account Name, decimal amountToAdd, bool expected)
        {
            AccountReopsitory repo = AccountRepositoryFactory.CreateAccountReopsitory();

           // Name = repo.AccountList.ContainsValue(Name.Name = "Johnny Manziel");






        }
    }
}
