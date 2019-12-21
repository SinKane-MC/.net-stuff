using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RateCalc_PowerCo;

namespace CustomerDataTests
{
    [TestClass]
    public class IndustrialTests
    {
        [TestMethod]
        public void CalculateRateIndustrialZeroHoursTest()
        {
            // Arrange
            Industrial client = new Industrial(); // create a new client object
            decimal returnAmt; // holds the return from CaclulateRate()
            decimal expectedAmt = 116.00m; // $116 is the base rate an Industrial customer will pay for usage under 1000hrs for both Peak and Off Peak
            client.PeakHours = 0; // set the usage hours to 0
            client.OffPeakHours = 0;

            // Act
            returnAmt = client.CalculateRate();

            // Assert
            Assert.AreEqual(expectedAmt, returnAmt);

        }

        [TestMethod]
        public void CalculateRateIndustrialBelowBaseHoursTest()
        {
            // Arrange
            Industrial client = new Industrial(); // create a new client object
            decimal returnAmt; // holds the return from CaclulateRate()
            decimal expectedAmt = 116.00m; // $116 is the base rate an Industrial customer will pay for usage under 1000hrs for both Peak and Off Peak
            client.PeakHours = 900; // set the usage hours to 900
            client.OffPeakHours = 900;

            // Act
            returnAmt = client.CalculateRate();

            // Assert
            Assert.AreEqual(expectedAmt, returnAmt);

        }

        [TestMethod]
        public void CalculateRateIndustrialAboveBaseHoursTest()
        {
            // Arrange
            Industrial client = new Industrial(); // create a new client object
            decimal returnAmt; // holds the return from CaclulateRate()
            decimal expectedAmt = 209.00m; // $116 is the base rate for Industrial customer will pay for usage under 1000hrs for both Peak and Off Peak
                                           //plus $65 for 1000 over @ $0.065/hr (Peak) and $28 for 1000 over @ $0.028/hr (Off Peak)
            client.PeakHours = 2000; // set the usage hours to 2000
            client.OffPeakHours = 2000;

            // Act
            returnAmt = client.CalculateRate();

            // Assert
            Assert.AreEqual(expectedAmt, returnAmt);

        }

        [TestMethod]
        public void CalculateRateIndustrialAboveBaseHoursTest2()
        {
            // Arrange
            Industrial client = new Industrial(); // create a new client object
            decimal returnAmt; // holds the return from CaclulateRate()
            decimal expectedAmt = 265.00m; // $116 is the base rate for Industrial customer will pay for usage under 1000hrs for both Peak and Off Peak
                                           //plus $65 for 1000 over @ $0.065/hr (Peak) and $84 for 3000 over @ $0.028/hr (Off Peak)
            client.PeakHours = 2000; // set the usage hours to 2000
            client.OffPeakHours = 4000;// setting the OP hours to a differnet amount 

            // Act
            returnAmt = client.CalculateRate();

            // Assert
            Assert.AreEqual(expectedAmt, returnAmt);

        }

        [TestMethod]
        // This test should be redundant since the validation in the input feilds and at the class level make it HIGHLY unlikely 
        // a negative value will ever be passed into the calculation
        public void CalculateRateIndustrialNegativeHoursTest()
        {
            // Arrange
            Industrial client = new Industrial(); // create a new client object
            decimal returnAmt; // holds the return from CaclulateRate()
            decimal expectedAmt = 116.00m; // $6 is the base rate a Residential customer will pay regardless of usage
            client.PeakHours = -100; // set the usage hours to -100, validation should set it to 0
            client.OffPeakHours = -100;                          
            // Act
            returnAmt = client.CalculateRate();

            // Assert
            Assert.AreEqual(expectedAmt, returnAmt);

        }
    }
}
