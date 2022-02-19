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
        private Account acc;

        [TestInitialize]
        // This needs to be public
        public void CreateDefaultAccount()
        {
            acc = new Account("J. Doe");
        }

        [TestMethod()]
        [DataRow(100)]
        [DataRow(.01)]
        [DataRow(1.99)]
        [DataRow(9_999.99)]
        public void Desposit_APositiveAmount_A(double depositAmount)
        {
            // Arrange
            acc.Deposit(depositAmount);
            // Assert
            Assert.AreEqual(depositAmount, acc.Balance);
        }

        [TestMethod]
        public void Desposit_APositiveAmount_ReturnsUpdatedBalance()
        {
            // Arrange
            double depositAmount = 100; 
            double expectedReturn = 100;

            // Act
            double returnValue = acc.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedReturn, returnValue);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void Deposit_ZeroOrLess_ThrowsArgumentException(double invalidDepositAmount)
        {
            // Arrange
            // Nothing to add

            // Assert => Act
            Assert.ThrowsException<ArgumentOutOfRangeException>
                (() => acc.Deposit(invalidDepositAmount));
        }

        // Withdrawing a positive amount
        // Withdrawing 0 - throws ArgumentRangeException
        // Withdrawing negative amount - throws ArgumentOutRange exception
        // Withdrawing more than available balance ArgumentException

        [TestMethod]
        public void Withdraw_PositiveAmount_DecreasesBalance()
        {
            // Arrange
            double initialDeposit = 100;
            double withDrawalAmount = 50;
            double expectedBalance = initialDeposit - withDrawalAmount;

            // Act
            acc.Deposit(initialDeposit);
            acc.Withdraw(withDrawalAmount);

            double actualBalance = acc.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);

        }
    }
}