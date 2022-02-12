using Microsoft.VisualStudio.TestTools.UnitTesting;
using PastryShop.Models;

namespace PastryShop.TestTools
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfItem_Item()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void FindTotal_ReturnsTotal_Int()
    {
      int amount = 3;
      int result = Bread.FindTotal(amount);
      Assert.AreEqual(10, result);
    }
  }
}