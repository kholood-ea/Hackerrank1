using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class FindDigitsUnitTest
    {
        [TestMethod]
        public void findDigitsShouldReturn0()
        {
            int shouldBeZero = Problems.FindDigits.findDigits(0);
            Assert.AreEqual(0, shouldBeZero);
        }
        [TestMethod]
        public void findDigitsForTwoDigitsNumber()
        {
            int a = Problems.FindDigits.findDigits(10);
            int b = Problems.FindDigits.findDigits(21);
            int c = Problems.FindDigits.findDigits(32);
            int d = Problems.FindDigits.findDigits(43);
            int e = Problems.FindDigits.findDigits(54);
            int f = Problems.FindDigits.findDigits(65);
            int g = Problems.FindDigits.findDigits(76);
            int h = Problems.FindDigits.findDigits(87);
            int i = Problems.FindDigits.findDigits(98);
            int j = Problems.FindDigits.findDigits(22);



            Assert.AreEqual(1, a);
            Assert.AreEqual(1, b);
            Assert.AreEqual(1, c);
            Assert.AreEqual(0, d);
            Assert.AreEqual(0, e);
            Assert.AreEqual(1, f);
            Assert.AreEqual(0, g);
            Assert.AreEqual(0, h);
            Assert.AreEqual(0, i);
            Assert.AreEqual(2, j);

        }
    }
}
