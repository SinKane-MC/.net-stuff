using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RateCalc_PowerCo;

namespace CustomerDataTests
{
    [TestClass]
    public class ResidentialTests
    {
        [TestMethod]
        public void CalculateRateResidentialZeroHoursTest()
        {
            // Arrange
            Residential client = new Residential(); // create a new client object
            decimal returnAmt; // holds the return from CaclulateRate()
            decimal expectedAmt = 6.00m; // $6 is the base rate a Residential customer will pay regardless of usage
            client.Hours = 0; // set the usage hours to 0

            // Act
            returnAmt = client.CalculateRate();

            // Assert
            Assert.AreEqual(expectedAmt, returnAmt);

        }
        [TestMethod]
        public void CalculateRateResidentialNonZeroHoursTest()
        {
            // Arrange
            Residential client = new Residential(); // create a new client object
            decimal returnAmt; // holds the return from CaclulateRate()
            decimal expectedAmt = 11.20m; // $6 is the base rate a Residential customer will pay regardless of usage, plus 5.20 for 100 hours * $0.052/hr
            client.Hours = 100; // set the usage hours to 100

            // Act
            returnAmt = client.CalculateRate();

            // Assert
            Assert.AreEqual(expectedAmt, returnAmt);

        }
        [TestMethod]
        // This test should be redundant since the validation in the input feilds and at the class level make it HIGHLY unlikely 
        // a negative value will ever be passed into the calculation
        public void CalculateRateResidentialNegativeHoursTest()
        {
            // Arrange
            Residential client = new Residential(); // create a new client object
            decimal returnAmt; // holds the return from CaclulateRate()
            decimal expectedAmt = 6.00m; // $6 is the base rate a Residential customer will pay regardless of usage
            client.Hours = -100; // set the usage hours to -100, validation should set it to 0

            // Act
            returnAmt = client.CalculateRate();

            // Assert
            Assert.AreEqual(expectedAmt, returnAmt);

        }
    }
}
