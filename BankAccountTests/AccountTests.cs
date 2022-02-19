using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void Desposit_APositiveAmount_A()
        {
            Account acc = new Account("J. Doe");
            acc.Deposit(100);

            Assert.AreEqual(100, acc.Balance);
        }

        [TestMethod]
        public void Despoit_APositiveAmount_ReturnsUpdatedBalance()
        {
            Account acc = new Account("J. Doe");
            double depositAmount = 100; 
            double expectedReturn = 100;

            double returnValue = acc.Deposit(depositAmount);

            Assert.AreEqual(expectedReturn, returnValue);
        }
    }
}