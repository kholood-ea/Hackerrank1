using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class LoveLetterMysteryUnitTest
    {
        [TestMethod]
        public void theLoveLetterMysteryUnitTest()
        {
            Assert.AreEqual(2,Problems.LoveLetterMystery.theLoveLetterMystery("abc"));
            Assert.AreEqual(0, Problems.LoveLetterMystery.theLoveLetterMystery("abcba"));
            Assert.AreEqual(4, Problems.LoveLetterMystery.theLoveLetterMystery("abcd"));
            Assert.AreEqual(2, Problems.LoveLetterMystery.theLoveLetterMystery("cba"));
            Assert.AreEqual(0, Problems.LoveLetterMystery.theLoveLetterMystery(""));
            Assert.AreEqual(6, Problems.LoveLetterMystery.theLoveLetterMystery("lmnop"));
            Assert.AreEqual(36, Problems.LoveLetterMystery.theLoveLetterMystery("adslkfjas"));
            Assert.AreEqual(13, Problems.LoveLetterMystery.theLoveLetterMystery("bafhaef"));
            Assert.AreEqual(40, Problems.LoveLetterMystery.theLoveLetterMystery("ofrhase"));
        }
    }
}
