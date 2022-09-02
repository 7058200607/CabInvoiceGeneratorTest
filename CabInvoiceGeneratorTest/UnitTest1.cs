using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class Tests 
    {
        InvoiceGenerator invoiceGenerator = null;
        [TestMethod]
     
      
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
        [TestMethod]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 5) };
            InvoiceSummery summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummery expected = invoiceGenerator.CalculateFare(rides);
            Assert.AreEqual(expected, summary);
        }
        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFarePremium()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 40;
            Assert.AreEqual(expected, fare);
        }
        [TestMethod]
        public void GivenMultipleRideShouldReturnInvoiceSummaryPremium()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 5) };
            InvoiceSummery summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummery expected = invoiceGenerator.CalculateFare(rides);
            Assert.AreEqual(expected, summary);
        }
    }
}