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
    public void NumberTest()
    {
      NumberConverter numberCov = new NumberConverter(1);
      Assert.AreEqual(1, numberCov.test());
    }
  }
}
