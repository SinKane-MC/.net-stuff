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
            Assert.AreEqual(expectedAmt, returnAmt);

            
            // Assert



        }
    }
}
