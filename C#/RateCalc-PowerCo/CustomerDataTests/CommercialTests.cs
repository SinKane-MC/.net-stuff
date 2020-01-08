using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RateCalc_PowerCo;

namespace CustomerDataTests
{
    [TestClass]
    public class CommercialTests
    {
        [TestMethod]
        public void CalculateRateCommercialZeroHoursTest()
        {
            // Arrange
            Commercial client = new Commercial(); // create a new client object
            decimal returnAmt; // holds the return from CaclulateRate()
            decimal expectedAmt = 60.00m; // $60 is the base rate a Commercial customer will pay for usage under 1000hrs
            client.Hours = 0; // set the usage hours to 0

            // Act
            returnAmt = client.CalculateRate();

            // Assert
            Assert.AreEqual(expectedAmt, returnAmt);

        }

        [TestMethod]
        public void CalculateRateCommercialBelowBaseHoursTest()
        {
            // Arrange
            Commercial client = new Commercial(); // create a new client object
            decimal returnAmt; // holds the return from CaclulateRate()
            decimal expectedAmt = 60.00m; // $60 is the base rate a Commercial customer will pay for usage under 1000hrs
            client.Hours = 900; // set the usage hours to 900

            // Act
            returnAmt = client.CalculateRate();

            // Assert
            Assert.AreEqual(expectedAmt, returnAmt);

        }

        [TestMethod]
        public void CalculateRateCommercialNonZeroHoursTest()
        {
            // Arrange
            Commercial client = new Commercial(); // create a new client object
            decimal returnAmt; // holds the return from CaclulateRate()
            decimal expectedAmt = 105.00m; // $60 is the base rate a Commercial customer will pay for usage under 1000hrs, plus $45 for 1000 over @ $0.045/hr
            client.Hours = 2000; // set the usage hours to 2000

            // Act
            returnAmt = client.CalculateRate();

            // Assert
            Assert.AreEqual(expectedAmt, returnAmt);

        }
        [TestMethod]
        // This test should be redundant since the validation in the input feilds and at the class level make it HIGHLY unlikely 
        // a negative value will ever be passed into the calculation
        public void CalculateRateCommercialNegativeHoursTest()
        {
            // Arrange
            Commercial client = new Commercial(); // create a new client object
            decimal returnAmt; // holds the return from CaclulateRate()
            decimal expectedAmt = 60.00m; // $6 is the base rate a Residential customer will pay regardless of usage
            client.Hours = -100; // set the usage hours to -100, validation should set it to 0

            // Act
            returnAmt = client.CalculateRate();

            // Assert
            Assert.AreEqual(expectedAmt, returnAmt);

        }
    }
}
