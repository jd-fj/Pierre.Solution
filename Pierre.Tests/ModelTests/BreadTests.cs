using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;

namespace Pierre.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      string testString = "ima string!";
      Bread newBread = new Bread();
      Assert.AreEqual(testString.GetType(), newBread.GetType());
    }
  }
}