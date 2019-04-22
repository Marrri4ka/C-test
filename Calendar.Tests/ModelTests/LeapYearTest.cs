using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.Tests
{
  [TestClass]
  public class LeapYearTest
  {
    [TestMethod]
    // Test method will go here
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
      //testing code will go here
    }
  }
}
