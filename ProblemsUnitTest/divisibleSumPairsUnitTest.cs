using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class divisibleSumPairsUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 6;
            int k = 3;
            int[] ar = { 1, 3, 2, 6, 1, 2 };
            int ActualResult = Problems.DivisibleSumPairs.divisibleSumPairs(n, k, ar);
            int ExpectedResult = 5;
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int n = 6;
            int k = 5;
            int[] ar = { 1, 2, 3, 4, 5, 6 };
            int ActualResult = Problems.DivisibleSumPairs.divisibleSumPairs(n, k, ar);
            int ExpectedResult = 3;
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
