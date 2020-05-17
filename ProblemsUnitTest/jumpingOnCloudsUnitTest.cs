using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class jumpingOnCloudsUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 0, 0, 1, 0, 0, 1, 1, 0 };
            Assert.AreEqual(Problems.JumpingOnClouds.jumpingOnClouds(array, 2), 94);
        }
    }
}
