using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingData.Tests
{
    [TestClass()]
    public class AccountTests
    {
        //constructor with positive initial balance
        [TestMethod()]
        public void TestConstructorPositiveInitial()
        {
            // Arrange
            Account acct; // declare reference variable
            decimal initial = 100;
            decimal expectedBalance = 100;
            decimal actualBalance;

            // Act
            acct = new Account(initial); // create account with initial balance
            actualBalance = acct.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }


        //constructor with negative initial balance
        [TestMethod()]
        public void TestConstructorNegativeInitial()
        {
            // Arrange
            Account acct; // declare reference variable
            decimal initial = -100;
            decimal expectedBalance = 0;
            decimal actualBalance;

            // Act
            acct = new Account(initial); // create account with initial balance
            actualBalance = acct.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }
        //deposit with positive amount
        [TestMethod()]
        public void DepositTestPositiveAmount()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = 100;
            decimal expectedBalance = 600;
            decimal actualBalance;

            // Act
            acct.Deposit(amount);
            actualBalance = acct.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }


        //deposit with negative amount
        [TestMethod()]
        public void DepositTestNegativeAmount()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = -100;
            decimal expectedBalance = 500;
            decimal actualBalance;

            // Act
            acct.Deposit(amount);
            actualBalance = acct.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        // withdraw with negative amount
        [TestMethod()]
        public void WithdrawTestNegativeAmount()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = -100;
            decimal expectedBalance = 500;
            bool expectedResult = true;
            decimal actualBalance;
            bool actualResult;

            // Act
            actualResult = acct.Withdraw(amount);
            actualBalance = acct.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }

        // withdraw with positive amount <= balance
        [TestMethod()]
        public void WithdrawTestPositiveAmount()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = 100;
            decimal expectedBalance = 400;
            bool expectedResult = true;
            decimal actualBalance;
            bool actualResult;

            // Act
            actualResult = acct.Withdraw(amount);
            actualBalance = acct.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }

        // withdraw with positive amount > balance (NSF)
        [TestMethod()]
        public void WithdrawTestNSF()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = 700;
            decimal expectedBalance = 500;
            bool expectedResult = false;
            decimal actualBalance;
            bool actualResult;

            // Act
            actualResult = acct.Withdraw(amount);
            actualBalance = acct.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}