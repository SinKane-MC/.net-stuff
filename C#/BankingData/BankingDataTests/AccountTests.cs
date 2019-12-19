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
        // constructor with negative inital balance
        [TestMethod()]
        public void ConstructorTestNegativeInitial()
        {
            // Arrange
            Account acct; // = new Account(500);
            decimal initial = -100;
            decimal expectBal = 0;
            decimal actualBal;
            // Act

            acct = new Account(initial);
            actualBal = acct.Balance;

            // Assert
            Assert.AreEqual(expectBal, actualBal);

        }
        // constructor with positive inital balance
        [TestMethod()]
        public void ConstructorTestPositiveInitial()
        {
            // Arrange
            Account acct; // = new Account(500);
            decimal initial = 100;
            decimal expectBal = 100;
            decimal actualBal;
            // Act

            acct = new Account(initial);
            actualBal = acct.Balance;

            // Assert
            Assert.AreEqual(expectBal, actualBal);

        }

        //depostit with positive amount
        [TestMethod()]
        public void DepositTestPositiveAmt()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = 100;
            decimal expectBal = 600;
            decimal actualBal;
            // Act

            acct.Deposit(amount);
            actualBal = acct.Balance;

            // Assert
            Assert.AreEqual(expectBal, actualBal);

        }

        // deposit with negative amount
        [TestMethod()]
        public void DepositTestNegativeAmt()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = -100;
            decimal expectBal = 500;
            decimal actualBal;
            // Act

            acct.Deposit(amount);
            actualBal = acct.Balance;

            // Assert
            Assert.AreEqual(expectBal, actualBal);

        }

        //withdrawl with negative amount
        [TestMethod()]
        public void WithdrawlTestNegativeAmt()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = -100;
            decimal expectBal = 500;
            decimal actualBal;
            // Act

            acct.Withdrawl(amount);
            actualBal = acct.Balance;

            // Assert
            Assert.AreEqual(expectBal, actualBal);

        }
        [TestMethod()]
        //withdrawl with positive amount less than balance
        public void WithdrawlTestPosAmt()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = 100;
            decimal expectBal = 400;
            decimal actualBal;
            // Act

            acct.Withdrawl(amount);
            actualBal = acct.Balance;

            // Assert
            Assert.AreEqual(expectBal, actualBal);

        }
        [TestMethod()]
        //withdrawl with positive amount Greater than balance
        public void WithdrawlTestPosAmtLessThan()
        {
            // Arrange
            Account acct = new Account(500);
            decimal amount = 600;
            decimal expectBal = 500;
            decimal actualBal;
            // Act

            acct.Withdrawl(amount);
            actualBal = acct.Balance;

            // Assert
            Assert.AreEqual(expectBal, actualBal);

        }
    }
}