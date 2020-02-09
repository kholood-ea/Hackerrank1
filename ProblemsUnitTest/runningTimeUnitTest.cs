using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class runningTimeUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] ar = {2, 1, 3, 1, 2 };
            Assert.AreEqual(4, Problems.AlgorithmsRunningTime.runningTime(ar));
        }
        [TestMethod]
        public void TestMethodshouldReturn0()
        {
            int[] ar = { 1, 1, 2, 2, 3 ,3, 5, 5 ,7 ,7 ,9 ,9 };
            Assert.AreEqual(0, Problems.AlgorithmsRunningTime.runningTime(ar));
        }
    }
}
