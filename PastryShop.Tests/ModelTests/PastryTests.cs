using Microsoft.VisualStudio.TestTools.UnitTesting;
using PastryShop.Models;

namespace PastryShop.TestTools
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfBread_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
      public void FindTotal_ReturnsTotal_Int01()
      {
        int amount = 3;
        int result = Pastry.FindTotal(amount);
        Assert.AreEqual(5, result);
      }
      [TestMethod]
      public void FindTotal_ReturnsTotal_Int02()
      {
        int amount = 6;
        int result = Pastry.FindTotal(amount);
        Assert.AreEqual(10, result);
      }
      [TestMethod]
      public void FindTotal_ReturnsTotal_Int03()
      {
        int amount = 2;
        int result = Pastry.FindTotal(amount);
        Assert.AreEqual(4, result);
      }
  }
}