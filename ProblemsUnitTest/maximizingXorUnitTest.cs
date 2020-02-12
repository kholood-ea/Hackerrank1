using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class maximizingXorUnitTest
    {
        [TestMethod]
        public void maximizingXorShouldReturnVal()
        {
            Assert.AreEqual(7, Problems.MaximizingXOR.maximizingXor(10, 15));
            Assert.AreEqual(127, Problems.MaximizingXOR.maximizingXor(11, 100)); 
        }
        [TestMethod]
        public void maximizingXorShouldReturn0()
        {
            Assert.AreEqual(0, Problems.MaximizingXOR.maximizingXor(10, 10));
            Assert.AreEqual(0, Problems.MaximizingXOR.maximizingXor(11, 11));
            Assert.AreEqual(0, Problems.MaximizingXOR.maximizingXor(12, 12));
            Assert.AreEqual(0, Problems.MaximizingXOR.maximizingXor(13, 13));
            Assert.AreEqual(0, Problems.MaximizingXOR.maximizingXor(14, 14));
            Assert.AreEqual(0, Problems.MaximizingXOR.maximizingXor(15, 15));

        }
    }
}
