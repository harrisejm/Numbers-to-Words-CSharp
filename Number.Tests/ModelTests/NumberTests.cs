using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

using Number;
namespace Number.Tests
{
  [TestClass]
  public class NumberOutput
  {
    [TestMethod]
    public void NumberTestSingle()
    {
      NumberConverter numberCov = new NumberConverter("1");
      Assert.AreEqual("one", numberCov.test());
    }
    [TestMethod]
    public void NumberTestTens()
    {
      NumberConverter numberCov = new NumberConverter("10");
      Assert.AreEqual("ten", numberCov.test());
    }
    [TestMethod]
    public void NumberTest100s()
    {
      NumberConverter numberCov = new NumberConverter("99");
      Assert.AreEqual("nintynine", numberCov.test());
    }
  }
}
