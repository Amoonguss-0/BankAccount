﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a single customers bank account
    /// </summary>
    internal class Account
    {
        /// <summary>
        /// Creates a account with a specific owner and a balance of 0
        /// </summary>
        /// <param name="accOwner">The customer full name that owns the account</param>
        public Account(string accOwner)
        {
            Owner = accOwner;
        }
        /// <summary>
        /// Account holders full name (first and last)
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Amount of money to the account
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        /// Adds a specified amount of money to the account
        /// </summary>
        /// <param name="amt">The positive amount to deposit</param>

        public void Deposit(double amt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Withdraws an amount of money from the balance
        /// </summary>
        /// <param name="amt">The positive amount of money to be taken from the balance</param>
        public void Withdraw(double amt)
        {
            throw new NotImplementedException();
        }
    }
}