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
      Bread newBreadOrder = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
    [TestMethod]
    public void
    GetTotalCost_ReturnsTotalCostOfBread_Int()
    {
      int quantity = 2;
      int falseQuant = 3;
      Bread newBreadOrder = new Bread(quantity);
      int result = newBreadOrder.Quantity;
      Assert.AreEqual(falseQuant, result);
    }
  }
}