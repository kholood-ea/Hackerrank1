using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace ProblemsUnitTest
{
    [TestClass]
    public class bonAppetitUnitTest
    {
        [TestMethod]
        public void bonAppetitShouldReturnBonAppetit()

        {
             List<int> first = new List<int> { 3,10,2,9 };
            Assert.AreEqual("Bon Appetit",Problems.BonAppétit.bonAppetit(first,1,7));
        }
        [TestMethod]
        public void bonAppetitShouldReturndifference()

        {
            List<int> first = new List<int> { 3, 10, 2, 9 };
            Assert.AreEqual("5", Problems.BonAppétit.bonAppetit(first, 1, 12));
        }
    }
}
